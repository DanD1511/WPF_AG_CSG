from domain.entities.powerfactory import PowerFactory
from domain.entities.pf_dto import PFDto
from fastapi import APIRouter


router = APIRouter()


@router.post("/GetGenerator")
def get_generator(dto: PFDto):
    pf = PowerFactory()
    generator = pf.get_generator(dto.name)
    return generator.loc_name
