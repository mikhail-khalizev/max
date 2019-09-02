using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e594-3da1f97f")]
        public void /* sys */ Method_1018_e594()
        {
            ii(0x1018_e594, 1); push(ebp);                              /* push ebp */
            ii(0x1018_e595, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_e597, 3); add(esp, -0x10 /* 0xf0 */);             /* add esp, 0xfffffff0 */
            ii(0x1018_e59a, 1); push(esi);                              /* push esi */
            ii(0x1018_e59b, 1); push(edi);                              /* push edi */
            ii(0x1018_e59c, 1); push(ebx);                              /* push ebx */
            ii(0x1018_e59d, 7); cmp(memd[ds, 0x1020_9ccc], 0);          /* cmp dword [0x10209ccc], 0x0 */
            ii(0x1018_e5a4, 2); if(jz(0x1018_e5c8, 0x22)) goto l_0x1018_e5c8; /* jz 0x1018e5c8 */
            ii(0x1018_e5a6, 3); push(memd[ss, ebp + 32]);               /* push dword [ebp+0x20] */
            ii(0x1018_e5a9, 3); push(memd[ss, ebp + 28]);               /* push dword [ebp+0x1c] */
            ii(0x1018_e5ac, 3); push(memd[ss, ebp + 24]);               /* push dword [ebp+0x18] */
            ii(0x1018_e5af, 3); push(memd[ss, ebp + 20]);               /* push dword [ebp+0x14] */
            ii(0x1018_e5b2, 3); push(memd[ss, ebp + 16]);               /* push dword [ebp+0x10] */
            ii(0x1018_e5b5, 3); push(memd[ss, ebp + 12]);               /* push dword [ebp+0xc] */
            ii(0x1018_e5b8, 3); push(memd[ss, ebp + 8]);                /* push dword [ebp+0x8] */
            ii(0x1018_e5bb, 5); call(/* sys */ 0x1018_e106, -0x4ba);    /* call 0x1018e106 */
            ii(0x1018_e5c0, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1018_e5c3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_e5c4, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e5c5, 1); pop(esi);                               /* pop esi */
            ii(0x1018_e5c6, 1); leave();                                /* leave */
            ii(0x1018_e5c7, 1); ret(); return;                          /* ret */
        l_0x1018_e5c8:
            ii(0x1018_e5c8, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1018_e5cb, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1018_e5ce, 5); mov(eax, memd[ds, 0x1020_9cd8]);        /* mov eax, [0x10209cd8] */
            ii(0x1018_e5d3, 6); sub(eax, memd[ds, 0x1020_9cc8]);        /* sub eax, [0x10209cc8] */
            ii(0x1018_e5d9, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1018_e5dc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e5de, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1018_e5e4, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1018_e5e7, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e5ea, 5); mov(memd[ds, 0x1020_9ce0], eax);        /* mov [0x10209ce0], eax */
            ii(0x1018_e5ef, 3); mov(eax, memd[ss, ebp + 28]);           /* mov eax, [ebp+0x1c] */
            ii(0x1018_e5f2, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e5f5, 5); mov(memd[ds, 0x1020_9cdc], eax);        /* mov [0x10209cdc], eax */
            ii(0x1018_e5fa, 3); mov(eax, memd[ss, ebp + 24]);           /* mov eax, [ebp+0x18] */
            ii(0x1018_e5fd, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e600, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e602, 5); mov(memd[ds, 0x1020_9ce4], eax);        /* mov [0x10209ce4], eax */
            ii(0x1018_e607, 3); mov(eax, memd[ss, ebp + 32]);           /* mov eax, [ebp+0x20] */
            ii(0x1018_e60a, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e60d, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e60f, 5); mov(memd[ds, 0x1020_9cd4], eax);        /* mov [0x10209cd4], eax */
            ii(0x1018_e614, 5); mov(eax, memd[ds, 0x1020_9cc4]);        /* mov eax, [0x10209cc4] */
            ii(0x1018_e619, 6); sub(eax, memd[ds, 0x1020_9cdc]);        /* sub eax, [0x10209cdc] */
            ii(0x1018_e61f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1018_e622, 5); mov(eax, memd[ds, 0x1020_9cc8]);        /* mov eax, [0x10209cc8] */
            ii(0x1018_e627, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1018_e62a, 4); cmp(memd[ss, ebp + 20], 0);             /* cmp dword [ebp+0x14], 0x0 */
            ii(0x1018_e62e, 2); if(jnz(0x1018_e636, 6)) goto l_0x1018_e636; /* jnz 0x1018e636 */
            ii(0x1018_e630, 4); cmp(memd[ss, ebp + 24], 0);             /* cmp dword [ebp+0x18], 0x0 */
            ii(0x1018_e634, 2); if(jz(0x1018_e64a, 0x14)) goto l_0x1018_e64a; /* jz 0x1018e64a */
        l_0x1018_e636:
            ii(0x1018_e636, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1018_e63b, 6); mul(memd[ds, 0x1020_9cd0]);             /* mul dword [0x10209cd0] */
            ii(0x1018_e641, 6); add(eax, memd[ds, 0x1020_9ce0]);        /* add eax, [0x10209ce0] */
            ii(0x1018_e647, 3); add(memd[ss, ebp - 4], eax);            /* add [ebp-0x4], eax */
        l_0x1018_e64a:
            ii(0x1018_e64a, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1018_e64d, 6); mov(edx, memd[ds, 0x1020_9ce8]);        /* mov edx, [0x10209ce8] */
            ii(0x1018_e653, 3); mov(esi, memd[ss, ebp + 16]);           /* mov esi, [ebp+0x10] */
            ii(0x1018_e656, 3); mov(ebx, memd[ss, ebp + 12]);           /* mov ebx, [ebp+0xc] */
            ii(0x1018_e659, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1018_e65c, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1018_e65f, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1018_e664, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
        l_0x1018_e66a:
            ii(0x1018_e66a, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e66b, 1); push(edi);                              /* push edi */
            ii(0x1018_e66c, 3); mov(ch, memb[ss, ebp + 32]);            /* mov ch, [ebp+0x20] */
        l_0x1018_e66f:
            ii(0x1018_e66f, 3); mov(cl, memb[ss, ebp + 28]);            /* mov cl, [ebp+0x1c] */
        l_0x1018_e672:
            ii(0x1018_e672, 3); add(ax, ax);                            /* add ax, ax */
            ii(0x1018_e675, 2); if(ja(0x1018_e682, 0xb)) goto l_0x1018_e682; /* ja 0x1018e682 */
            ii(0x1018_e677, 2); if(jz(0x1018_e69e, 0x25)) goto l_0x1018_e69e; /* jz 0x1018e69e */
            ii(0x1018_e679, 4); cmp(memw[ds, ebx], 0);                  /* cmp word [ebx], 0x0 */
            ii(0x1018_e67d, 2); if(jz(0x1018_e6aa, 0x2b)) goto l_0x1018_e6aa; /* jz 0x1018e6aa */
            ii(0x1018_e67f, 3); add(ebx, 2);                            /* add ebx, 0x2 */
        l_0x1018_e682:
            ii(0x1018_e682, 3); add(edi, 8);                            /* add edi, 0x8 */
        l_0x1018_e685:
            ii(0x1018_e685, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e687, 2); if(jnz(0x1018_e672, -0x17)) goto l_0x1018_e672; /* jnz 0x1018e672 */
            ii(0x1018_e689, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e68c, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e68e, 2); if(jnz(0x1018_e66f, -0x21)) goto l_0x1018_e66f; /* jnz 0x1018e66f */
            ii(0x1018_e690, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e691, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e692, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e698, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e69a, 2); if(jnz(0x1018_e66a, -0x32)) goto l_0x1018_e66a; /* jnz 0x1018e66a */
            ii(0x1018_e69c, 2); jmp(0x1018_e6d3, 0x35); goto l_0x1018_e6d3; /* jmp 0x1018e6d3 */
        l_0x1018_e69e:
            ii(0x1018_e69e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1018_e6a1, 4); add(memd[ss, ebp - 16], 2);             /* add dword [ebp-0x10], 0x2 */
            ii(0x1018_e6a5, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1018_e6a8, 2); jmp(0x1018_e672, -0x38); goto l_0x1018_e672; /* jmp 0x1018e672 */
        l_0x1018_e6aa:
            ii(0x1018_e6aa, 1); movsd();                                /* movsd */
            ii(0x1018_e6ab, 1); movsd();                                /* movsd */
            ii(0x1018_e6ac, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e6ae, 1); movsd();                                /* movsd */
            ii(0x1018_e6af, 1); movsd();                                /* movsd */
            ii(0x1018_e6b0, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e6b2, 1); movsd();                                /* movsd */
            ii(0x1018_e6b3, 1); movsd();                                /* movsd */
            ii(0x1018_e6b4, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e6b6, 1); movsd();                                /* movsd */
            ii(0x1018_e6b7, 1); movsd();                                /* movsd */
            ii(0x1018_e6b8, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e6ba, 1); movsd();                                /* movsd */
            ii(0x1018_e6bb, 1); movsd();                                /* movsd */
            ii(0x1018_e6bc, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e6be, 1); movsd();                                /* movsd */
            ii(0x1018_e6bf, 1); movsd();                                /* movsd */
            ii(0x1018_e6c0, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e6c2, 1); movsd();                                /* movsd */
            ii(0x1018_e6c3, 1); movsd();                                /* movsd */
            ii(0x1018_e6c4, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e6c6, 1); movsd();                                /* movsd */
            ii(0x1018_e6c7, 1); movsd();                                /* movsd */
            ii(0x1018_e6c8, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e6ce, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e6d1, 2); jmp(0x1018_e685, -0x4e); goto l_0x1018_e685; /* jmp 0x1018e685 */
        l_0x1018_e6d3:
            ii(0x1018_e6d3, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1018_e6d6, 3); mov(ebx, memd[ss, ebp + 12]);           /* mov ebx, [ebp+0xc] */
            ii(0x1018_e6d9, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1018_e6dc, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1018_e6df, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1018_e6e4, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
            ii(0x1018_e6ea, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1018_e6ec:
            ii(0x1018_e6ec, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e6ed, 1); push(edi);                              /* push edi */
            ii(0x1018_e6ee, 3); mov(ch, memb[ss, ebp + 32]);            /* mov ch, [ebp+0x20] */
        l_0x1018_e6f1:
            ii(0x1018_e6f1, 3); mov(cl, memb[ss, ebp + 28]);            /* mov cl, [ebp+0x1c] */
        l_0x1018_e6f4:
            ii(0x1018_e6f4, 3); add(ax, ax);                            /* add ax, ax */
            ii(0x1018_e6f7, 2); if(ja(0x1018_e705, 0xc)) goto l_0x1018_e705; /* ja 0x1018e705 */
            ii(0x1018_e6f9, 2); if(jz(0x1018_e724, 0x29)) goto l_0x1018_e724; /* jz 0x1018e724 */
            ii(0x1018_e6fb, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e6fe, 2); if(jg(0x1018_e735, 0x35)) goto l_0x1018_e735; /* jg 0x1018e735 */
            ii(0x1018_e700, 2); if(jl(0x1018_e730, 0x2e)) goto l_0x1018_e730; /* jl 0x1018e730 */
            ii(0x1018_e702, 3); add(ebx, 2);                            /* add ebx, 0x2 */
        l_0x1018_e705:
            ii(0x1018_e705, 3); add(edi, 8);                            /* add edi, 0x8 */
        l_0x1018_e708:
            ii(0x1018_e708, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e70a, 2); if(jnz(0x1018_e6f4, -0x18)) goto l_0x1018_e6f4; /* jnz 0x1018e6f4 */
            ii(0x1018_e70c, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e70f, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e711, 2); if(jnz(0x1018_e6f1, -0x22)) goto l_0x1018_e6f1; /* jnz 0x1018e6f1 */
            ii(0x1018_e713, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e714, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e715, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e71b, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e71d, 2); if(jnz(0x1018_e6ec, -0x33)) goto l_0x1018_e6ec; /* jnz 0x1018e6ec */
            ii(0x1018_e71f, 5); jmp(0x1018_e7fe, 0xda); goto l_0x1018_e7fe; /* jmp 0x1018e7fe */
        l_0x1018_e724:
            ii(0x1018_e724, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1018_e727, 4); add(memd[ss, ebp - 16], 2);             /* add dword [ebp-0x10], 0x2 */
            ii(0x1018_e72b, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1018_e72e, 2); jmp(0x1018_e6f4, -0x3c); goto l_0x1018_e6f4; /* jmp 0x1018e6f4 */
        l_0x1018_e730:
            ii(0x1018_e730, 5); jmp(0x1018_e7bb, 0x86); goto l_0x1018_e7bb; /* jmp 0x1018e7bb */
        l_0x1018_e735:
            ii(0x1018_e735, 7); lea(esi, memd[ds, edi + esi - 16384]);  /* lea esi, [edi+esi-0x4000] */
            ii(0x1018_e73c, 1); movsd();                                /* movsd */
            ii(0x1018_e73d, 1); movsd();                                /* movsd */
            ii(0x1018_e73e, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e740, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e742, 1); movsd();                                /* movsd */
            ii(0x1018_e743, 1); movsd();                                /* movsd */
            ii(0x1018_e744, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e746, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e748, 1); movsd();                                /* movsd */
            ii(0x1018_e749, 1); movsd();                                /* movsd */
            ii(0x1018_e74a, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e74c, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e74e, 1); movsd();                                /* movsd */
            ii(0x1018_e74f, 1); movsd();                                /* movsd */
            ii(0x1018_e750, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e752, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e754, 1); movsd();                                /* movsd */
            ii(0x1018_e755, 1); movsd();                                /* movsd */
            ii(0x1018_e756, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e758, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e75a, 1); movsd();                                /* movsd */
            ii(0x1018_e75b, 1); movsd();                                /* movsd */
            ii(0x1018_e75c, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e75e, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e760, 1); movsd();                                /* movsd */
            ii(0x1018_e761, 1); movsd();                                /* movsd */
            ii(0x1018_e762, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e764, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e766, 1); movsd();                                /* movsd */
            ii(0x1018_e767, 1); movsd();                                /* movsd */
            ii(0x1018_e768, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e76e, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e770, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e773, 2); jmp(0x1018_e708, -0x6d); goto l_0x1018_e708; /* jmp 0x1018e708 */
        l_0x1018_e775:
            ii(0x1018_e775, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e776, 1); push(edi);                              /* push edi */
            ii(0x1018_e777, 3); mov(ch, memb[ss, ebp + 32]);            /* mov ch, [ebp+0x20] */
        l_0x1018_e77a:
            ii(0x1018_e77a, 3); mov(cl, memb[ss, ebp + 28]);            /* mov cl, [ebp+0x1c] */
        l_0x1018_e77d:
            ii(0x1018_e77d, 3); add(ax, ax);                            /* add ax, ax */
            ii(0x1018_e780, 2); if(ja(0x1018_e78e, 0xc)) goto l_0x1018_e78e; /* ja 0x1018e78e */
            ii(0x1018_e782, 2); if(jz(0x1018_e7aa, 0x26)) goto l_0x1018_e7aa; /* jz 0x1018e7aa */
            ii(0x1018_e784, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e787, 2); if(jl(0x1018_e7bb, 0x32)) goto l_0x1018_e7bb; /* jl 0x1018e7bb */
            ii(0x1018_e789, 2); if(jg(0x1018_e7b6, 0x2b)) goto l_0x1018_e7b6; /* jg 0x1018e7b6 */
            ii(0x1018_e78b, 3); add(ebx, 2);                            /* add ebx, 0x2 */
        l_0x1018_e78e:
            ii(0x1018_e78e, 3); add(edi, 8);                            /* add edi, 0x8 */
        l_0x1018_e791:
            ii(0x1018_e791, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e793, 2); if(jnz(0x1018_e77d, -0x18)) goto l_0x1018_e77d; /* jnz 0x1018e77d */
            ii(0x1018_e795, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e798, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e79a, 2); if(jnz(0x1018_e77a, -0x22)) goto l_0x1018_e77a; /* jnz 0x1018e77a */
            ii(0x1018_e79c, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e79d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e79e, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e7a4, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e7a6, 2); if(jnz(0x1018_e775, -0x33)) goto l_0x1018_e775; /* jnz 0x1018e775 */
            ii(0x1018_e7a8, 2); jmp(0x1018_e7fe, 0x54); goto l_0x1018_e7fe; /* jmp 0x1018e7fe */
        l_0x1018_e7aa:
            ii(0x1018_e7aa, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1018_e7ad, 4); add(memd[ss, ebp - 16], 2);             /* add dword [ebp-0x10], 0x2 */
            ii(0x1018_e7b1, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1018_e7b4, 2); jmp(0x1018_e77d, -0x39); goto l_0x1018_e77d; /* jmp 0x1018e77d */
        l_0x1018_e7b6:
            ii(0x1018_e7b6, 5); jmp(0x1018_e735, -0x86); goto l_0x1018_e735; /* jmp 0x1018e735 */
        l_0x1018_e7bb:
            ii(0x1018_e7bb, 7); lea(esi, memd[ds, edi + esi - 49152]);  /* lea esi, [edi+esi-0xc000] */
            ii(0x1018_e7c2, 3); add(esi, memd[ss, ebp - 12]);           /* add esi, [ebp-0xc] */
            ii(0x1018_e7c5, 1); movsd();                                /* movsd */
            ii(0x1018_e7c6, 1); movsd();                                /* movsd */
            ii(0x1018_e7c7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e7c9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e7cb, 1); movsd();                                /* movsd */
            ii(0x1018_e7cc, 1); movsd();                                /* movsd */
            ii(0x1018_e7cd, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e7cf, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e7d1, 1); movsd();                                /* movsd */
            ii(0x1018_e7d2, 1); movsd();                                /* movsd */
            ii(0x1018_e7d3, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e7d5, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e7d7, 1); movsd();                                /* movsd */
            ii(0x1018_e7d8, 1); movsd();                                /* movsd */
            ii(0x1018_e7d9, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e7db, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e7dd, 1); movsd();                                /* movsd */
            ii(0x1018_e7de, 1); movsd();                                /* movsd */
            ii(0x1018_e7df, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e7e1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e7e3, 1); movsd();                                /* movsd */
            ii(0x1018_e7e4, 1); movsd();                                /* movsd */
            ii(0x1018_e7e5, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e7e7, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e7e9, 1); movsd();                                /* movsd */
            ii(0x1018_e7ea, 1); movsd();                                /* movsd */
            ii(0x1018_e7eb, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e7ed, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e7ef, 1); movsd();                                /* movsd */
            ii(0x1018_e7f0, 1); movsd();                                /* movsd */
            ii(0x1018_e7f1, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e7f7, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e7fa, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e7fc, 2); jmp(0x1018_e791, -0x6d); goto l_0x1018_e791; /* jmp 0x1018e791 */
        l_0x1018_e7fe:
            ii(0x1018_e7fe, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_e7ff, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e800, 1); pop(esi);                               /* pop esi */
            ii(0x1018_e801, 1); leave();                                /* leave */
            ii(0x1018_e802, 1); ret();                                  /* ret */
        }
    }
}
