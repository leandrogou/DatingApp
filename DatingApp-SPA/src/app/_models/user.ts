import { Photo } from './photo';
export interface User {
    id: number;
    username: string;
    apelido: string;
    age: number;
    sexo: string;
    criadoEm: Date;
    ultimoLogin: Date;
    photoUrl: string;
    cidade: string;
    estado: string;
    pais: string;
    interesses?: string;
    introducao?: string;
    procurandoPor?: string;
    photos?: Photo[];
}
