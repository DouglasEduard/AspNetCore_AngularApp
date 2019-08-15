import { Photo } from './Photo';

export interface Talent {
    Id: number;
    userName: string;
    name: string;
    age: number;
    skype: string;
    phone: string;
    eMail: string;
    linkedIn: string;
    city: string;
    state: string;
    portifolio: string;
    willingnessToWork: number;
    bestTimeToWork: Date;
    hourlySalaryRequirements: string;
    photoUrl: string;
    photos?: Photo[]; 
}
