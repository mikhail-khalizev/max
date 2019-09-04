using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e37a-e973bc65")]
        public void /* sys */ Method_1018_e37a()
        {
            ii(0x1018_e37a, 1); push(ebp);                              /* push ebp */
            ii(0x1018_e37b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_e37d, 3); add(esp, -0x10 /* 0xf0 */);             /* add esp, 0xfffffff0 */
            ii(0x1018_e380, 1); push(esi);                              /* push esi */
            ii(0x1018_e381, 1); push(edi);                              /* push edi */
            ii(0x1018_e382, 1); push(ebx);                              /* push ebx */
            ii(0x1018_e383, 7); cmp(memd[ds, 0x1020_9ccc], 0);          /* cmp dword [0x10209ccc], 0x0 */
            ii(0x1018_e38a, 2); if(jz(0x1018_e3a8, 0x1c)) goto l_0x1018_e3a8; /* jz 0x1018e3a8 */
            ii(0x1018_e38c, 3); push(memd[ss, ebp + 24]);               /* push dword [ebp+0x18] */
            ii(0x1018_e38f, 3); push(memd[ss, ebp + 20]);               /* push dword [ebp+0x14] */
            ii(0x1018_e392, 3); push(memd[ss, ebp + 16]);               /* push dword [ebp+0x10] */
            ii(0x1018_e395, 3); push(memd[ss, ebp + 12]);               /* push dword [ebp+0xc] */
            ii(0x1018_e398, 3); push(memd[ss, ebp + 8]);                /* push dword [ebp+0x8] */
            ii(0x1018_e39b, 5); call(/* sys */ 0x1018_dee1, -0x4bf);    /* call 0x1018dee1 */
            ii(0x1018_e3a0, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1018_e3a3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_e3a4, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e3a5, 1); pop(esi);                               /* pop esi */
            ii(0x1018_e3a6, 1); leave();                                /* leave */
            ii(0x1018_e3a7, 1); ret(); return;                          /* ret */
        l_0x1018_e3a8:
            ii(0x1018_e3a8, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1018_e3ab, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1018_e3ae, 5); mov(eax, memd[ds, 0x1020_9cd8]);        /* mov eax, [0x10209cd8] */
            ii(0x1018_e3b3, 6); sub(eax, memd[ds, 0x1020_9cc8]);        /* sub eax, [0x10209cc8] */
            ii(0x1018_e3b9, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1018_e3bc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e3be, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1018_e3c4, 3); mov(eax, memd[ss, ebp + 12]);           /* mov eax, [ebp+0xc] */
            ii(0x1018_e3c7, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e3ca, 5); mov(memd[ds, 0x1020_9ce0], eax);        /* mov [0x10209ce0], eax */
            ii(0x1018_e3cf, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1018_e3d2, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e3d5, 5); mov(memd[ds, 0x1020_9cdc], eax);        /* mov [0x10209cdc], eax */
            ii(0x1018_e3da, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x1018_e3dd, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e3e0, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e3e2, 5); mov(memd[ds, 0x1020_9ce4], eax);        /* mov [0x10209ce4], eax */
            ii(0x1018_e3e7, 3); mov(eax, memd[ss, ebp + 24]);           /* mov eax, [ebp+0x18] */
            ii(0x1018_e3ea, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e3ed, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e3ef, 5); mov(memd[ds, 0x1020_9cd4], eax);        /* mov [0x10209cd4], eax */
            ii(0x1018_e3f4, 5); mov(eax, memd[ds, 0x1020_9cc4]);        /* mov eax, [0x10209cc4] */
            ii(0x1018_e3f9, 6); sub(eax, memd[ds, 0x1020_9cdc]);        /* sub eax, [0x10209cdc] */
            ii(0x1018_e3ff, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1018_e402, 5); mov(eax, memd[ds, 0x1020_9cc8]);        /* mov eax, [0x10209cc8] */
            ii(0x1018_e407, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1018_e40a, 4); cmp(memd[ss, ebp + 12], 0);             /* cmp dword [ebp+0xc], 0x0 */
            ii(0x1018_e40e, 2); if(jnz(0x1018_e416, 6)) goto l_0x1018_e416; /* jnz 0x1018e416 */
            ii(0x1018_e410, 4); cmp(memd[ss, ebp + 16], 0);             /* cmp dword [ebp+0x10], 0x0 */
            ii(0x1018_e414, 2); if(jz(0x1018_e42a, 0x14)) goto l_0x1018_e42a; /* jz 0x1018e42a */
        l_0x1018_e416:
            ii(0x1018_e416, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1018_e41b, 6); mul(memd[ds, 0x1020_9cd0]);             /* mul dword [0x10209cd0] */
            ii(0x1018_e421, 6); add(eax, memd[ds, 0x1020_9ce0]);        /* add eax, [0x10209ce0] */
            ii(0x1018_e427, 3); add(memd[ss, ebp - 4], eax);            /* add [ebp-0x4], eax */
        l_0x1018_e42a:
            ii(0x1018_e42a, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1018_e42d, 3); mul(memd[ss, ebp + 24]);                /* mul dword [ebp+0x18] */
            ii(0x1018_e430, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e432, 2); shl(eax, 1);                            /* shl eax, 1 */
            ii(0x1018_e434, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1018_e437, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1018_e43a, 6); mov(edx, memd[ds, 0x1020_9ce8]);        /* mov edx, [0x10209ce8] */
            ii(0x1018_e440, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1018_e443, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1018_e445, 3); add(esi, memd[ss, ebp - 16]);           /* add esi, [ebp-0x10] */
            ii(0x1018_e448, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
        l_0x1018_e44e:
            ii(0x1018_e44e, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e44f, 1); push(edi);                              /* push edi */
            ii(0x1018_e450, 3); mov(ch, memb[ss, ebp + 24]);            /* mov ch, [ebp+0x18] */
        l_0x1018_e453:
            ii(0x1018_e453, 3); mov(cl, memb[ss, ebp + 20]);            /* mov cl, [ebp+0x14] */
        l_0x1018_e456:
            ii(0x1018_e456, 4); cmp(memw[ds, ebx], 0);                  /* cmp word [ebx], 0x0 */
            ii(0x1018_e45a, 2); if(jz(0x1018_e47b, 0x1f)) goto l_0x1018_e47b; /* jz 0x1018e47b */
            ii(0x1018_e45c, 3); add(edi, 8);                            /* add edi, 0x8 */
        l_0x1018_e45f:
            ii(0x1018_e45f, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e462, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e464, 2); if(jnz(0x1018_e456, -0x10)) goto l_0x1018_e456; /* jnz 0x1018e456 */
            ii(0x1018_e466, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e469, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e46b, 2); if(jnz(0x1018_e453, -0x1a)) goto l_0x1018_e453; /* jnz 0x1018e453 */
            ii(0x1018_e46d, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e46e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e46f, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e475, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e477, 2); if(jnz(0x1018_e44e, -0x2b)) goto l_0x1018_e44e; /* jnz 0x1018e44e */
            ii(0x1018_e479, 2); jmp(0x1018_e4a1, 0x26); goto l_0x1018_e4a1; /* jmp 0x1018e4a1 */
        l_0x1018_e47b:
            ii(0x1018_e47b, 1); movsd();                                /* movsd */
            ii(0x1018_e47c, 1); movsd();                                /* movsd */
            ii(0x1018_e47d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e47f, 1); movsd();                                /* movsd */
            ii(0x1018_e480, 1); movsd();                                /* movsd */
            ii(0x1018_e481, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e483, 1); movsd();                                /* movsd */
            ii(0x1018_e484, 1); movsd();                                /* movsd */
            ii(0x1018_e485, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e487, 1); movsd();                                /* movsd */
            ii(0x1018_e488, 1); movsd();                                /* movsd */
            ii(0x1018_e489, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e48b, 1); movsd();                                /* movsd */
            ii(0x1018_e48c, 1); movsd();                                /* movsd */
            ii(0x1018_e48d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e48f, 1); movsd();                                /* movsd */
            ii(0x1018_e490, 1); movsd();                                /* movsd */
            ii(0x1018_e491, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e493, 1); movsd();                                /* movsd */
            ii(0x1018_e494, 1); movsd();                                /* movsd */
            ii(0x1018_e495, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e497, 1); movsd();                                /* movsd */
            ii(0x1018_e498, 1); movsd();                                /* movsd */
            ii(0x1018_e499, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e49f, 2); jmp(0x1018_e45f, -0x42); goto l_0x1018_e45f; /* jmp 0x1018e45f */
        l_0x1018_e4a1:
            ii(0x1018_e4a1, 3); sub(ebx, memd[ss, ebp - 16]);           /* sub ebx, [ebp-0x10] */
            ii(0x1018_e4a4, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1018_e4a7, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
            ii(0x1018_e4ad, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1018_e4af:
            ii(0x1018_e4af, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e4b0, 1); push(edi);                              /* push edi */
            ii(0x1018_e4b1, 3); mov(ch, memb[ss, ebp + 24]);            /* mov ch, [ebp+0x18] */
        l_0x1018_e4b4:
            ii(0x1018_e4b4, 3); mov(cl, memb[ss, ebp + 20]);            /* mov cl, [ebp+0x14] */
        l_0x1018_e4b7:
            ii(0x1018_e4b7, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e4ba, 2); if(jg(0x1018_e4e2, 0x26)) goto l_0x1018_e4e2; /* jg 0x1018e4e2 */
            ii(0x1018_e4bc, 2); if(jl(0x1018_e4e0, 0x22)) goto l_0x1018_e4e0; /* jl 0x1018e4e0 */
            ii(0x1018_e4be, 3); add(edi, 8);                            /* add edi, 0x8 */
        l_0x1018_e4c1:
            ii(0x1018_e4c1, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e4c4, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e4c6, 2); if(jnz(0x1018_e4b7, -0x11)) goto l_0x1018_e4b7; /* jnz 0x1018e4b7 */
            ii(0x1018_e4c8, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e4cb, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e4cd, 2); if(jnz(0x1018_e4b4, -0x1b)) goto l_0x1018_e4b4; /* jnz 0x1018e4b4 */
            ii(0x1018_e4cf, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e4d0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e4d1, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e4d7, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e4d9, 2); if(jnz(0x1018_e4af, -0x2c)) goto l_0x1018_e4af; /* jnz 0x1018e4af */
            ii(0x1018_e4db, 5); jmp(0x1018_e58f, 0xaf); goto l_0x1018_e58f; /* jmp 0x1018e58f */
        l_0x1018_e4e0:
            ii(0x1018_e4e0, 2); jmp(0x1018_e54f, 0x6d); goto l_0x1018_e54f; /* jmp 0x1018e54f */
        l_0x1018_e4e2:
            ii(0x1018_e4e2, 7); lea(esi, memd[ds, edi + esi - 0x4000]); /* lea esi, [edi+esi-0x4000] */
            ii(0x1018_e4e9, 1); movsd();                                /* movsd */
            ii(0x1018_e4ea, 1); movsd();                                /* movsd */
            ii(0x1018_e4eb, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e4ed, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e4ef, 1); movsd();                                /* movsd */
            ii(0x1018_e4f0, 1); movsd();                                /* movsd */
            ii(0x1018_e4f1, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e4f3, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e4f5, 1); movsd();                                /* movsd */
            ii(0x1018_e4f6, 1); movsd();                                /* movsd */
            ii(0x1018_e4f7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e4f9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e4fb, 1); movsd();                                /* movsd */
            ii(0x1018_e4fc, 1); movsd();                                /* movsd */
            ii(0x1018_e4fd, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e4ff, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e501, 1); movsd();                                /* movsd */
            ii(0x1018_e502, 1); movsd();                                /* movsd */
            ii(0x1018_e503, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e505, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e507, 1); movsd();                                /* movsd */
            ii(0x1018_e508, 1); movsd();                                /* movsd */
            ii(0x1018_e509, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e50b, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e50d, 1); movsd();                                /* movsd */
            ii(0x1018_e50e, 1); movsd();                                /* movsd */
            ii(0x1018_e50f, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e511, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e513, 1); movsd();                                /* movsd */
            ii(0x1018_e514, 1); movsd();                                /* movsd */
            ii(0x1018_e515, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e51b, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e51d, 2); jmp(0x1018_e4c1, -0x5e); goto l_0x1018_e4c1; /* jmp 0x1018e4c1 */
        l_0x1018_e51f:
            ii(0x1018_e51f, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e520, 1); push(edi);                              /* push edi */
            ii(0x1018_e521, 3); mov(ch, memb[ss, ebp + 24]);            /* mov ch, [ebp+0x18] */
        l_0x1018_e524:
            ii(0x1018_e524, 3); mov(cl, memb[ss, ebp + 20]);            /* mov cl, [ebp+0x14] */
        l_0x1018_e527:
            ii(0x1018_e527, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e52a, 2); if(jl(0x1018_e54f, 0x23)) goto l_0x1018_e54f; /* jl 0x1018e54f */
            ii(0x1018_e52c, 2); if(jg(0x1018_e54d, 0x1f)) goto l_0x1018_e54d; /* jg 0x1018e54d */
            ii(0x1018_e52e, 3); add(edi, 8);                            /* add edi, 0x8 */
        l_0x1018_e531:
            ii(0x1018_e531, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e534, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e536, 2); if(jnz(0x1018_e527, -0x11)) goto l_0x1018_e527; /* jnz 0x1018e527 */
            ii(0x1018_e538, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e53b, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e53d, 2); if(jnz(0x1018_e524, -0x1b)) goto l_0x1018_e524; /* jnz 0x1018e524 */
            ii(0x1018_e53f, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e540, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e541, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e547, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e549, 2); if(jnz(0x1018_e51f, -0x2c)) goto l_0x1018_e51f; /* jnz 0x1018e51f */
            ii(0x1018_e54b, 2); jmp(0x1018_e58f, 0x42); goto l_0x1018_e58f; /* jmp 0x1018e58f */
        l_0x1018_e54d:
            ii(0x1018_e54d, 2); jmp(0x1018_e4e2, -0x6d); goto l_0x1018_e4e2; /* jmp 0x1018e4e2 */
        l_0x1018_e54f:
            ii(0x1018_e54f, 7); lea(esi, memd[ds, edi + esi - 0xc000]); /* lea esi, [edi+esi-0xc000] */
            ii(0x1018_e556, 3); add(esi, memd[ss, ebp - 12]);           /* add esi, [ebp-0xc] */
            ii(0x1018_e559, 1); movsd();                                /* movsd */
            ii(0x1018_e55a, 1); movsd();                                /* movsd */
            ii(0x1018_e55b, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e55d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e55f, 1); movsd();                                /* movsd */
            ii(0x1018_e560, 1); movsd();                                /* movsd */
            ii(0x1018_e561, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e563, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e565, 1); movsd();                                /* movsd */
            ii(0x1018_e566, 1); movsd();                                /* movsd */
            ii(0x1018_e567, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e569, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e56b, 1); movsd();                                /* movsd */
            ii(0x1018_e56c, 1); movsd();                                /* movsd */
            ii(0x1018_e56d, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e56f, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e571, 1); movsd();                                /* movsd */
            ii(0x1018_e572, 1); movsd();                                /* movsd */
            ii(0x1018_e573, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e575, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e577, 1); movsd();                                /* movsd */
            ii(0x1018_e578, 1); movsd();                                /* movsd */
            ii(0x1018_e579, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e57b, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e57d, 1); movsd();                                /* movsd */
            ii(0x1018_e57e, 1); movsd();                                /* movsd */
            ii(0x1018_e57f, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e581, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e583, 1); movsd();                                /* movsd */
            ii(0x1018_e584, 1); movsd();                                /* movsd */
            ii(0x1018_e585, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e58b, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e58d, 2); jmp(0x1018_e531, -0x5e); goto l_0x1018_e531; /* jmp 0x1018e531 */
        l_0x1018_e58f:
            ii(0x1018_e58f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_e590, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e591, 1); pop(esi);                               /* pop esi */
            ii(0x1018_e592, 1); leave();                                /* leave */
            ii(0x1018_e593, 1); ret();                                  /* ret */
        }
    }
}
