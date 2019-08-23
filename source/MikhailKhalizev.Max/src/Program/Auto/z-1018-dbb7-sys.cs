using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_dbb7-a04c0c28")]
        public void /* sys */ Method_1018_dbb7()
        {
            ii(0x1018_dbb7, 1); push(ebx);                              /* push ebx */
            ii(0x1018_dbb8, 1); push(edx);                              /* push edx */
            ii(0x1018_dbb9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_dbbb, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1018_dbbd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_dbbf, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_dbc1, 5); call(/* sys */ 0x1018_d3e2, -0x7e4);    /* call 0x1018d3e2 */
            ii(0x1018_dbc6, 6); cmp(ebx, 0x100);                        /* cmp ebx, 0x100 */
            ii(0x1018_dbcc, 2); if(jae(0x1018_dc11, 0x43)) goto l_0x1018_dc11; /* jae 0x1018dc11 */
            ii(0x1018_dbce, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_dbd0, 5); mov(al, memb[ds, 0x101b_e597]);         /* mov al, [0x101be597] */
            ii(0x1018_dbd5, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1018_dbd8, 2); if(jl(0x1018_dbf7, 0x1d)) goto l_0x1018_dbf7; /* jl 0x1018dbf7 */
            ii(0x1018_dbda, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_dbdc, 2); mov(bl, dl);                            /* mov bl, dl */
            ii(0x1018_dbde, 3); cmp(ebx, 0x50);                         /* cmp ebx, 0x50 */
            ii(0x1018_dbe1, 2); if(jnz(0x1018_dbe7, 0x4)) goto l_0x1018_dbe7; /* jnz 0x1018dbe7 */
            ii(0x1018_dbe3, 2); mov(dl, 0xe);                           /* mov dl, 0xe */
            ii(0x1018_dbe5, 2); jmp(0x1018_dbf7, 0x10); goto l_0x1018_dbf7; /* jmp 0x1018dbf7 */
        l_0x1018_dbe7:
            ii(0x1018_dbe7, 3); cmp(ebx, 0x22);                         /* cmp ebx, 0x22 */
            ii(0x1018_dbea, 2); if(jl(0x1018_dbf0, 0x4)) goto l_0x1018_dbf0; /* jl 0x1018dbf0 */
            ii(0x1018_dbec, 2); mov(dl, 0x13);                          /* mov dl, 0x13 */
            ii(0x1018_dbee, 2); jmp(0x1018_dbf7, 0x7); goto l_0x1018_dbf7; /* jmp 0x1018dbf7 */
        l_0x1018_dbf0:
            ii(0x1018_dbf0, 3); cmp(ebx, 0x20);                         /* cmp ebx, 0x20 */
            ii(0x1018_dbf3, 2); if(jl(0x1018_dbf7, 0x2)) goto l_0x1018_dbf7; /* jl 0x1018dbf7 */
            ii(0x1018_dbf5, 2); mov(dl, 0x5);                           /* mov dl, 0x5 */
        l_0x1018_dbf7:
            ii(0x1018_dbf7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_dbf9, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1018_dbfb, 3); cmp(eax, 0x13);                         /* cmp eax, 0x13 */
            ii(0x1018_dbfe, 2); if(jle(0x1018_dc02, 0x2)) goto l_0x1018_dc02; /* jle 0x1018dc02 */
            ii(0x1018_dc00, 2); mov(dl, 0x13);                          /* mov dl, 0x13 */
        l_0x1018_dc02:
            ii(0x1018_dc02, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_dc04, 2); mov(bl, dl);                            /* mov bl, dl */
            ii(0x1018_dc06, 6); mov(eax, memd[ds, ebx + 0x101b_e8b9]);  /* mov eax, [ebx+0x101be8b9] */
            ii(0x1018_dc0c, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1018_dc0f, 2); jmp(0x1018_dc1b, 0xa); goto l_0x1018_dc1b; /* jmp 0x1018dc1b */
        l_0x1018_dc11:
            ii(0x1018_dc11, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_dc13, 3); shr(eax, 0x8);                          /* shr eax, 0x8 */
            ii(0x1018_dc16, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1018_dc1b:
            ii(0x1018_dc1b, 5); call(/* sys */ 0x1018_d3bf, -0x861);    /* call 0x1018d3bf */
            ii(0x1018_dc20, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1018_dc25, 1); pop(edx);                               /* pop edx */
            ii(0x1018_dc26, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_dc27, 1); ret();                                  /* ret */
        }
    }
}
