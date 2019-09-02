using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ddba-154565e0")]
        public void /* sys */ Method_1018_ddba()
        {
            ii(0x1018_ddba, 1); push(ebp);                              /* push ebp */
            ii(0x1018_ddbb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_ddbd, 1); push(esi);                              /* push esi */
            ii(0x1018_ddbe, 1); push(edi);                              /* push edi */
            ii(0x1018_ddbf, 1); push(ebx);                              /* push ebx */
            ii(0x1018_ddc0, 3); mov(ecx, memd[ss, ebp + 16]);           /* mov ecx, [ebp+0x10] */
            ii(0x1018_ddc3, 2); shr(ecx, 1);                            /* shr ecx, 1 */
            ii(0x1018_ddc5, 2); if(jz(0x1018_de1b, 0x54)) goto l_0x1018_de1b; /* jz 0x1018de1b */
            ii(0x1018_ddc7, 3); mov(esi, memd[ss, ebp + 12]);           /* mov esi, [ebp+0xc] */
            ii(0x1018_ddca, 3); mov(edi, memd[ss, ebp + 8]);            /* mov edi, [ebp+0x8] */
            ii(0x1018_ddcd, 3); mov(ax, memw[ds, esi]);                 /* mov ax, [esi] */
            ii(0x1018_ddd0, 3); add(esi, 2);                            /* add esi, 0x2 */
            ii(0x1018_ddd3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_ddd5, 3); mov(memw[ds, edi], ax);                 /* mov [edi], ax */
            ii(0x1018_ddd8, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1018_dddb, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_dddc, 2); if(jz(0x1018_de1b, 0x3d)) goto l_0x1018_de1b; /* jz 0x1018de1b */
            ii(0x1018_ddde, 3); mov(dx, memw[ds, esi]);                 /* mov dx, [esi] */
            ii(0x1018_dde1, 3); add(esi, 2);                            /* add esi, 0x2 */
            ii(0x1018_dde4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_dde6, 3); mov(memw[ds, edi], dx);                 /* mov [edi], dx */
            ii(0x1018_dde9, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1018_ddec, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_dded, 2); if(jz(0x1018_de1b, 0x2c)) goto l_0x1018_de1b; /* jz 0x1018de1b */
        l_0x1018_ddef:
            ii(0x1018_ddef, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_ddf1, 3); add(esi, 1);                            /* add esi, 0x1 */
            ii(0x1018_ddf4, 8); add(ax, memw[ds, ebx * 2 + 0x101b_e218]); /* add ax, [ebx*2+0x101be218] */
            ii(0x1018_ddfc, 3); mov(memw[ds, edi], ax);                 /* mov [edi], ax */
            ii(0x1018_ddff, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1018_de02, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_de03, 2); if(jz(0x1018_de1b, 0x16)) goto l_0x1018_de1b; /* jz 0x1018de1b */
            ii(0x1018_de05, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_de07, 3); add(esi, 1);                            /* add esi, 0x1 */
            ii(0x1018_de0a, 8); add(dx, memw[ds, ebx * 2 + 0x101b_e218]); /* add dx, [ebx*2+0x101be218] */
            ii(0x1018_de12, 3); mov(memw[ds, edi], dx);                 /* mov [edi], dx */
            ii(0x1018_de15, 3); add(edi, 2);                            /* add edi, 0x2 */
            ii(0x1018_de18, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_de19, 2); if(jnz(0x1018_ddef, -0x2c)) goto l_0x1018_ddef; /* jnz 0x1018ddef */
        l_0x1018_de1b:
            ii(0x1018_de1b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_de1c, 1); pop(edi);                               /* pop edi */
            ii(0x1018_de1d, 1); pop(esi);                               /* pop esi */
            ii(0x1018_de1e, 1); leave();                                /* leave */
            ii(0x1018_de1f, 1); ret();                                  /* ret */
        }
    }
}
