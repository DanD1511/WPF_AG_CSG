from pydantic import BaseModel


class PFDto(BaseModel):
    name: str
    data: dict
