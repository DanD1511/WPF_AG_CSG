from fastapi import FastAPI, APIRouter

from domain.entities.powerfactory import PowerFactory
from framework.powerfactory_service.powerfactory_service import router
import uvicorn

app = FastAPI()

app.include_router(router, prefix="/powerfactory")

if __name__ == "__main__":
    uvicorn.run(app, host="0.0.0.0", workers=0)