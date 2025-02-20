import os
import sys

os.environ["PATH"] = r"C:\\Program Files\\DIgSILENT\\PowerFactory 2021 SP2" + ";" + os.environ["PATH"]
sys.path.append(r'C:\\Program Files\\DIgSILENT\\PowerFactory 2021 SP2\\Python\\3.9')

import powerfactory as pf


class PowerFactory:
    def __init__(self):
        self.app = self._app_init()
        self.app.Show()
        self.activate_project()
        self.current_project = self.app.GetActiveProject()

    @staticmethod
    def _app_init():
        """
        Initializes the PowerFactory application and returns the application instance.

        Returns
        -------
        object
            The PowerFactory application instance.

        Raises
        ------
        Exception
            If PowerFactory cannot start.
        """
        try:
            app = pf.GetApplication()
            if not app:
                raise ValueError("PowerFactory cannot start.")
            return app
        except Exception as e:
            print(f"PowerFactory cannot start: {e}")
            sys.exit(1)

    def activate_project(self):
        self.app.ActivateProject("14 Bus System")

    def get_generator(self, gen_name):
        print("Getting generator", gen_name)
        print("Current project", self.current_project)
        generators = self.app.GetCalcRelevantObjects("*.ElmSym")
        print(generators)
        for generator in generators:
            if generator.loc_name == gen_name:
                return generator
