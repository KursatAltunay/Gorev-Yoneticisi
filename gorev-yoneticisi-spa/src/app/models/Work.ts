import { WorkType } from './WorkType';

export class Work {
    id:number;
    title:string;
    startDate:Date;
    finishDate:Date;
    workTypeId:number;
    location:string;
    detail:string;
    status:boolean;
    userId:number;
    workType:WorkType[]
}
