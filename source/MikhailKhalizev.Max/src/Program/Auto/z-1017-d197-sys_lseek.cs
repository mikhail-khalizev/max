using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d197-451b0515")]
        public void /* sys */ sys_lseek()
        {
            ii(0x1017_d197, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_d198, 1); pushd(edi);                             /* push edi */
            ii(0x1017_d199, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_d19c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_d19e, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1017_d1a0, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1017_d1a2, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1017_d1a4, 2); mov(ah, 0x42);                          /* mov ah, 0x42 */
            ii(0x1017_d1a6, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_d1a8, 3); shr(ecx, 0x10);                         /* shr ecx, 0x10 */
            ii(0x1017_d1ab, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_d1ad, 4); mov(memw_a32[ss, edi], ax);             /* mov [ss:edi], ax */
            ii(0x1017_d1b1, 5); mov(memw_a32[ss, edi + 0x2], dx);       /* mov [ss:edi+0x2], dx */
            ii(0x1017_d1b6, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1017_d1b8, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1017_d1ba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_d1bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d1be, 2); if(jged(0x1017_d1d1, 0x11)) goto l_0x1017_d1d1; /* jge 0x1017d1d1 */
            ii(0x1017_d1c0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d1c2, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1017_d1c5, 5); calld(/* sys */ 0x1018_dbb7, 0x1_09ed); /* call 0x1018dbb7 */
            ii(0x1017_d1ca, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_d1cf, 2); jmpd(0x1017_d1d4, 0x3); goto l_0x1017_d1d4; /* jmp 0x1017d1d4 */
        l_0x1017_d1d1:
            ii(0x1017_d1d1, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
        l_0x1017_d1d4:
            ii(0x1017_d1d4, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_d1d7, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d1d8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_d1d9, 1); retd();                                 /* ret */
        }
    }
}
