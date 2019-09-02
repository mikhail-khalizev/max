using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e106-d21ed4ee")]
        public void /* sys */ Method_1018_e106()
        {
            ii(0x1018_e106, 1); push(ebp);                              /* push ebp */
            ii(0x1018_e107, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_e109, 3); add(esp, -0x10 /* 0xf0 */);             /* add esp, 0xfffffff0 */
            ii(0x1018_e10c, 1); push(esi);                              /* push esi */
            ii(0x1018_e10d, 1); push(edi);                              /* push edi */
            ii(0x1018_e10e, 1); push(ebx);                              /* push ebx */
            ii(0x1018_e10f, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1018_e112, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1018_e115, 5); mov(eax, memd[ds, 0x1020_9cd8]);        /* mov eax, [0x10209cd8] */
            ii(0x1018_e11a, 6); sub(eax, memd[ds, 0x1020_9cc8]);        /* sub eax, [0x10209cc8] */
            ii(0x1018_e120, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1018_e123, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e125, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1018_e12b, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1018_e12e, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1018_e131, 5); mov(memd[ds, 0x1020_9ce0], eax);        /* mov [0x10209ce0], eax */
            ii(0x1018_e136, 3); mov(eax, memd[ss, ebp + 28]);           /* mov eax, [ebp+0x1c] */
            ii(0x1018_e139, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1018_e13c, 5); mov(memd[ds, 0x1020_9cdc], eax);        /* mov [0x10209cdc], eax */
            ii(0x1018_e141, 3); mov(eax, memd[ss, ebp + 24]);           /* mov eax, [ebp+0x18] */
            ii(0x1018_e144, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e147, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e149, 5); mov(memd[ds, 0x1020_9ce4], eax);        /* mov [0x10209ce4], eax */
            ii(0x1018_e14e, 3); mov(eax, memd[ss, ebp + 32]);           /* mov eax, [ebp+0x20] */
            ii(0x1018_e151, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1018_e154, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e156, 5); mov(memd[ds, 0x1020_9cd4], eax);        /* mov [0x10209cd4], eax */
            ii(0x1018_e15b, 5); mov(eax, memd[ds, 0x1020_9cc4]);        /* mov eax, [0x10209cc4] */
            ii(0x1018_e160, 6); sub(eax, memd[ds, 0x1020_9cdc]);        /* sub eax, [0x10209cdc] */
            ii(0x1018_e166, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1018_e169, 5); mov(eax, memd[ds, 0x1020_9cc8]);        /* mov eax, [0x10209cc8] */
            ii(0x1018_e16e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1018_e171, 4); cmp(memd[ss, ebp + 20], 0);             /* cmp dword [ebp+0x14], 0x0 */
            ii(0x1018_e175, 2); if(jnz(0x1018_e17d, 6)) goto l_0x1018_e17d; /* jnz 0x1018e17d */
            ii(0x1018_e177, 4); cmp(memd[ss, ebp + 24], 0);             /* cmp dword [ebp+0x18], 0x0 */
            ii(0x1018_e17b, 2); if(jz(0x1018_e191, 0x14)) goto l_0x1018_e191; /* jz 0x1018e191 */
        l_0x1018_e17d:
            ii(0x1018_e17d, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1018_e182, 6); mul(memd[ds, 0x1020_9cd0]);             /* mul dword [0x10209cd0] */
            ii(0x1018_e188, 6); add(eax, memd[ds, 0x1020_9ce0]);        /* add eax, [0x10209ce0] */
            ii(0x1018_e18e, 3); add(memd[ss, ebp - 4], eax);            /* add [ebp-0x4], eax */
        l_0x1018_e191:
            ii(0x1018_e191, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1018_e194, 6); mov(edx, memd[ds, 0x1020_9ce8]);        /* mov edx, [0x10209ce8] */
            ii(0x1018_e19a, 3); mov(esi, memd[ss, ebp + 16]);           /* mov esi, [ebp+0x10] */
            ii(0x1018_e19d, 3); mov(ebx, memd[ss, ebp + 12]);           /* mov ebx, [ebp+0xc] */
            ii(0x1018_e1a0, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1018_e1a3, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1018_e1a6, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1018_e1ab, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
        l_0x1018_e1b1:
            ii(0x1018_e1b1, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e1b2, 1); push(edi);                              /* push edi */
            ii(0x1018_e1b3, 3); mov(ch, memb[ss, ebp + 32]);            /* mov ch, [ebp+0x20] */
        l_0x1018_e1b6:
            ii(0x1018_e1b6, 3); mov(cl, memb[ss, ebp + 28]);            /* mov cl, [ebp+0x1c] */
        l_0x1018_e1b9:
            ii(0x1018_e1b9, 3); add(ax, ax);                            /* add ax, ax */
            ii(0x1018_e1bc, 2); if(ja(0x1018_e1c9, 0xb)) goto l_0x1018_e1c9; /* ja 0x1018e1c9 */
            ii(0x1018_e1be, 2); if(jz(0x1018_e1e5, 0x25)) goto l_0x1018_e1e5; /* jz 0x1018e1e5 */
            ii(0x1018_e1c0, 4); cmp(memw[ds, ebx], 0);                  /* cmp word [ebx], 0x0 */
            ii(0x1018_e1c4, 2); if(jz(0x1018_e1f1, 0x2b)) goto l_0x1018_e1f1; /* jz 0x1018e1f1 */
            ii(0x1018_e1c6, 3); add(ebx, 2);                            /* add ebx, 0x2 */
        l_0x1018_e1c9:
            ii(0x1018_e1c9, 3); add(edi, 0x10);                         /* add edi, 0x10 */
        l_0x1018_e1cc:
            ii(0x1018_e1cc, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e1ce, 2); if(jnz(0x1018_e1b9, -0x17)) goto l_0x1018_e1b9; /* jnz 0x1018e1b9 */
            ii(0x1018_e1d0, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e1d3, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e1d5, 2); if(jnz(0x1018_e1b6, -0x21)) goto l_0x1018_e1b6; /* jnz 0x1018e1b6 */
            ii(0x1018_e1d7, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e1d8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e1d9, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e1df, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e1e1, 2); if(jnz(0x1018_e1b1, -0x32)) goto l_0x1018_e1b1; /* jnz 0x1018e1b1 */
            ii(0x1018_e1e3, 2); jmp(0x1018_e22a, 0x45); goto l_0x1018_e22a; /* jmp 0x1018e22a */
        l_0x1018_e1e5:
            ii(0x1018_e1e5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1018_e1e8, 4); add(memd[ss, ebp - 16], 2);             /* add dword [ebp-0x10], 0x2 */
            ii(0x1018_e1ec, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1018_e1ef, 2); jmp(0x1018_e1b9, -0x38); goto l_0x1018_e1b9; /* jmp 0x1018e1b9 */
        l_0x1018_e1f1:
            ii(0x1018_e1f1, 1); movsd();                                /* movsd */
            ii(0x1018_e1f2, 1); movsd();                                /* movsd */
            ii(0x1018_e1f3, 1); movsd();                                /* movsd */
            ii(0x1018_e1f4, 1); movsd();                                /* movsd */
            ii(0x1018_e1f5, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e1f7, 1); movsd();                                /* movsd */
            ii(0x1018_e1f8, 1); movsd();                                /* movsd */
            ii(0x1018_e1f9, 1); movsd();                                /* movsd */
            ii(0x1018_e1fa, 1); movsd();                                /* movsd */
            ii(0x1018_e1fb, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e1fd, 1); movsd();                                /* movsd */
            ii(0x1018_e1fe, 1); movsd();                                /* movsd */
            ii(0x1018_e1ff, 1); movsd();                                /* movsd */
            ii(0x1018_e200, 1); movsd();                                /* movsd */
            ii(0x1018_e201, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e203, 1); movsd();                                /* movsd */
            ii(0x1018_e204, 1); movsd();                                /* movsd */
            ii(0x1018_e205, 1); movsd();                                /* movsd */
            ii(0x1018_e206, 1); movsd();                                /* movsd */
            ii(0x1018_e207, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e209, 1); movsd();                                /* movsd */
            ii(0x1018_e20a, 1); movsd();                                /* movsd */
            ii(0x1018_e20b, 1); movsd();                                /* movsd */
            ii(0x1018_e20c, 1); movsd();                                /* movsd */
            ii(0x1018_e20d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e20f, 1); movsd();                                /* movsd */
            ii(0x1018_e210, 1); movsd();                                /* movsd */
            ii(0x1018_e211, 1); movsd();                                /* movsd */
            ii(0x1018_e212, 1); movsd();                                /* movsd */
            ii(0x1018_e213, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e215, 1); movsd();                                /* movsd */
            ii(0x1018_e216, 1); movsd();                                /* movsd */
            ii(0x1018_e217, 1); movsd();                                /* movsd */
            ii(0x1018_e218, 1); movsd();                                /* movsd */
            ii(0x1018_e219, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e21b, 1); movsd();                                /* movsd */
            ii(0x1018_e21c, 1); movsd();                                /* movsd */
            ii(0x1018_e21d, 1); movsd();                                /* movsd */
            ii(0x1018_e21e, 1); movsd();                                /* movsd */
            ii(0x1018_e21f, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e225, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e228, 2); jmp(0x1018_e1cc, -0x5e); goto l_0x1018_e1cc; /* jmp 0x1018e1cc */
        l_0x1018_e22a:
            ii(0x1018_e22a, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1018_e22d, 3); mov(ebx, memd[ss, ebp + 12]);           /* mov ebx, [ebp+0xc] */
            ii(0x1018_e230, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1018_e233, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1018_e236, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1018_e23b, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
            ii(0x1018_e241, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1018_e243:
            ii(0x1018_e243, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e244, 1); push(edi);                              /* push edi */
            ii(0x1018_e245, 3); mov(ch, memb[ss, ebp + 32]);            /* mov ch, [ebp+0x20] */
        l_0x1018_e248:
            ii(0x1018_e248, 3); mov(cl, memb[ss, ebp + 28]);            /* mov cl, [ebp+0x1c] */
        l_0x1018_e24b:
            ii(0x1018_e24b, 3); add(ax, ax);                            /* add ax, ax */
            ii(0x1018_e24e, 2); if(ja(0x1018_e25c, 0xc)) goto l_0x1018_e25c; /* ja 0x1018e25c */
            ii(0x1018_e250, 2); if(jz(0x1018_e27b, 0x29)) goto l_0x1018_e27b; /* jz 0x1018e27b */
            ii(0x1018_e252, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e255, 2); if(jg(0x1018_e28c, 0x35)) goto l_0x1018_e28c; /* jg 0x1018e28c */
            ii(0x1018_e257, 2); if(jl(0x1018_e287, 0x2e)) goto l_0x1018_e287; /* jl 0x1018e287 */
            ii(0x1018_e259, 3); add(ebx, 2);                            /* add ebx, 0x2 */
        l_0x1018_e25c:
            ii(0x1018_e25c, 3); add(edi, 0x10);                         /* add edi, 0x10 */
        l_0x1018_e25f:
            ii(0x1018_e25f, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e261, 2); if(jnz(0x1018_e24b, -0x18)) goto l_0x1018_e24b; /* jnz 0x1018e24b */
            ii(0x1018_e263, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e266, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e268, 2); if(jnz(0x1018_e248, -0x22)) goto l_0x1018_e248; /* jnz 0x1018e248 */
            ii(0x1018_e26a, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e26b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e26c, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e272, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e274, 2); if(jnz(0x1018_e243, -0x33)) goto l_0x1018_e243; /* jnz 0x1018e243 */
            ii(0x1018_e276, 5); jmp(0x1018_e375, 0xfa); goto l_0x1018_e375; /* jmp 0x1018e375 */
        l_0x1018_e27b:
            ii(0x1018_e27b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1018_e27e, 4); add(memd[ss, ebp - 16], 2);             /* add dword [ebp-0x10], 0x2 */
            ii(0x1018_e282, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1018_e285, 2); jmp(0x1018_e24b, -0x3c); goto l_0x1018_e24b; /* jmp 0x1018e24b */
        l_0x1018_e287:
            ii(0x1018_e287, 5); jmp(0x1018_e322, 0x96); goto l_0x1018_e322; /* jmp 0x1018e322 */
        l_0x1018_e28c:
            ii(0x1018_e28c, 7); lea(esi, memd[ds, edi + esi * 2 - 32768]); /* lea esi, [edi+esi*2-0x8000] */
            ii(0x1018_e293, 1); movsd();                                /* movsd */
            ii(0x1018_e294, 1); movsd();                                /* movsd */
            ii(0x1018_e295, 1); movsd();                                /* movsd */
            ii(0x1018_e296, 1); movsd();                                /* movsd */
            ii(0x1018_e297, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e299, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e29b, 1); movsd();                                /* movsd */
            ii(0x1018_e29c, 1); movsd();                                /* movsd */
            ii(0x1018_e29d, 1); movsd();                                /* movsd */
            ii(0x1018_e29e, 1); movsd();                                /* movsd */
            ii(0x1018_e29f, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e2a1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e2a3, 1); movsd();                                /* movsd */
            ii(0x1018_e2a4, 1); movsd();                                /* movsd */
            ii(0x1018_e2a5, 1); movsd();                                /* movsd */
            ii(0x1018_e2a6, 1); movsd();                                /* movsd */
            ii(0x1018_e2a7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e2a9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e2ab, 1); movsd();                                /* movsd */
            ii(0x1018_e2ac, 1); movsd();                                /* movsd */
            ii(0x1018_e2ad, 1); movsd();                                /* movsd */
            ii(0x1018_e2ae, 1); movsd();                                /* movsd */
            ii(0x1018_e2af, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e2b1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e2b3, 1); movsd();                                /* movsd */
            ii(0x1018_e2b4, 1); movsd();                                /* movsd */
            ii(0x1018_e2b5, 1); movsd();                                /* movsd */
            ii(0x1018_e2b6, 1); movsd();                                /* movsd */
            ii(0x1018_e2b7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e2b9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e2bb, 1); movsd();                                /* movsd */
            ii(0x1018_e2bc, 1); movsd();                                /* movsd */
            ii(0x1018_e2bd, 1); movsd();                                /* movsd */
            ii(0x1018_e2be, 1); movsd();                                /* movsd */
            ii(0x1018_e2bf, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e2c1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e2c3, 1); movsd();                                /* movsd */
            ii(0x1018_e2c4, 1); movsd();                                /* movsd */
            ii(0x1018_e2c5, 1); movsd();                                /* movsd */
            ii(0x1018_e2c6, 1); movsd();                                /* movsd */
            ii(0x1018_e2c7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e2c9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e2cb, 1); movsd();                                /* movsd */
            ii(0x1018_e2cc, 1); movsd();                                /* movsd */
            ii(0x1018_e2cd, 1); movsd();                                /* movsd */
            ii(0x1018_e2ce, 1); movsd();                                /* movsd */
            ii(0x1018_e2cf, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e2d5, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e2d7, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e2da, 2); jmp(0x1018_e25f, -0x7d); goto l_0x1018_e25f; /* jmp 0x1018e25f */
        l_0x1018_e2dc:
            ii(0x1018_e2dc, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e2dd, 1); push(edi);                              /* push edi */
            ii(0x1018_e2de, 3); mov(ch, memb[ss, ebp + 32]);            /* mov ch, [ebp+0x20] */
        l_0x1018_e2e1:
            ii(0x1018_e2e1, 3); mov(cl, memb[ss, ebp + 28]);            /* mov cl, [ebp+0x1c] */
        l_0x1018_e2e4:
            ii(0x1018_e2e4, 3); add(ax, ax);                            /* add ax, ax */
            ii(0x1018_e2e7, 2); if(ja(0x1018_e2f5, 0xc)) goto l_0x1018_e2f5; /* ja 0x1018e2f5 */
            ii(0x1018_e2e9, 2); if(jz(0x1018_e311, 0x26)) goto l_0x1018_e311; /* jz 0x1018e311 */
            ii(0x1018_e2eb, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e2ee, 2); if(jl(0x1018_e322, 0x32)) goto l_0x1018_e322; /* jl 0x1018e322 */
            ii(0x1018_e2f0, 2); if(jg(0x1018_e31d, 0x2b)) goto l_0x1018_e31d; /* jg 0x1018e31d */
            ii(0x1018_e2f2, 3); add(ebx, 2);                            /* add ebx, 0x2 */
        l_0x1018_e2f5:
            ii(0x1018_e2f5, 3); add(edi, 0x10);                         /* add edi, 0x10 */
        l_0x1018_e2f8:
            ii(0x1018_e2f8, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e2fa, 2); if(jnz(0x1018_e2e4, -0x18)) goto l_0x1018_e2e4; /* jnz 0x1018e2e4 */
            ii(0x1018_e2fc, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1018_e2ff, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e301, 2); if(jnz(0x1018_e2e1, -0x22)) goto l_0x1018_e2e1; /* jnz 0x1018e2e1 */
            ii(0x1018_e303, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e304, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e305, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e30b, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e30d, 2); if(jnz(0x1018_e2dc, -0x33)) goto l_0x1018_e2dc; /* jnz 0x1018e2dc */
            ii(0x1018_e30f, 2); jmp(0x1018_e375, 0x64); goto l_0x1018_e375; /* jmp 0x1018e375 */
        l_0x1018_e311:
            ii(0x1018_e311, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1018_e314, 4); add(memd[ss, ebp - 16], 2);             /* add dword [ebp-0x10], 0x2 */
            ii(0x1018_e318, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1018_e31b, 2); jmp(0x1018_e2e4, -0x39); goto l_0x1018_e2e4; /* jmp 0x1018e2e4 */
        l_0x1018_e31d:
            ii(0x1018_e31d, 5); jmp(0x1018_e28c, -0x96); goto l_0x1018_e28c; /* jmp 0x1018e28c */
        l_0x1018_e322:
            ii(0x1018_e322, 7); lea(esi, memd[ds, edi + esi * 2 - 0x1_8000]); /* lea esi, [edi+esi*2-0x18000] */
            ii(0x1018_e329, 3); add(esi, memd[ss, ebp - 12]);           /* add esi, [ebp-0xc] */
            ii(0x1018_e32c, 1); movsd();                                /* movsd */
            ii(0x1018_e32d, 1); movsd();                                /* movsd */
            ii(0x1018_e32e, 1); movsd();                                /* movsd */
            ii(0x1018_e32f, 1); movsd();                                /* movsd */
            ii(0x1018_e330, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e332, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e334, 1); movsd();                                /* movsd */
            ii(0x1018_e335, 1); movsd();                                /* movsd */
            ii(0x1018_e336, 1); movsd();                                /* movsd */
            ii(0x1018_e337, 1); movsd();                                /* movsd */
            ii(0x1018_e338, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e33a, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e33c, 1); movsd();                                /* movsd */
            ii(0x1018_e33d, 1); movsd();                                /* movsd */
            ii(0x1018_e33e, 1); movsd();                                /* movsd */
            ii(0x1018_e33f, 1); movsd();                                /* movsd */
            ii(0x1018_e340, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e342, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e344, 1); movsd();                                /* movsd */
            ii(0x1018_e345, 1); movsd();                                /* movsd */
            ii(0x1018_e346, 1); movsd();                                /* movsd */
            ii(0x1018_e347, 1); movsd();                                /* movsd */
            ii(0x1018_e348, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e34a, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e34c, 1); movsd();                                /* movsd */
            ii(0x1018_e34d, 1); movsd();                                /* movsd */
            ii(0x1018_e34e, 1); movsd();                                /* movsd */
            ii(0x1018_e34f, 1); movsd();                                /* movsd */
            ii(0x1018_e350, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e352, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e354, 1); movsd();                                /* movsd */
            ii(0x1018_e355, 1); movsd();                                /* movsd */
            ii(0x1018_e356, 1); movsd();                                /* movsd */
            ii(0x1018_e357, 1); movsd();                                /* movsd */
            ii(0x1018_e358, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e35a, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e35c, 1); movsd();                                /* movsd */
            ii(0x1018_e35d, 1); movsd();                                /* movsd */
            ii(0x1018_e35e, 1); movsd();                                /* movsd */
            ii(0x1018_e35f, 1); movsd();                                /* movsd */
            ii(0x1018_e360, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e362, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e364, 1); movsd();                                /* movsd */
            ii(0x1018_e365, 1); movsd();                                /* movsd */
            ii(0x1018_e366, 1); movsd();                                /* movsd */
            ii(0x1018_e367, 1); movsd();                                /* movsd */
            ii(0x1018_e368, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e36e, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x1018_e371, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e373, 2); jmp(0x1018_e2f8, -0x7d); goto l_0x1018_e2f8; /* jmp 0x1018e2f8 */
        l_0x1018_e375:
            ii(0x1018_e375, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_e376, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e377, 1); pop(esi);                               /* pop esi */
            ii(0x1018_e378, 1); leave();                                /* leave */
            ii(0x1018_e379, 1); ret();                                  /* ret */
        }
    }
}
