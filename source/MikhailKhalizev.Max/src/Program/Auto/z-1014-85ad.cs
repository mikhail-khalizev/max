using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("65bc6b81-14b1-4cb9-b350-3eb49ff1cac9")]
        public void Method_1014_85ad()
        {
            ii(0x1014_85ad, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_85b2, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d79b); /* call 0x10165d52 */
            ii(0x1014_85b7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_85b8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_85b9, 1); pushd(edx);                             /* push edx */
            ii(0x1014_85ba, 1); pushd(esi);                             /* push esi */
            ii(0x1014_85bb, 1); pushd(edi);                             /* push edi */
            ii(0x1014_85bc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_85bd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_85bf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_85c5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_85c8, 5); calld(0x1014_82f4, -0x2d9);             /* call 0x101482f4 */
            ii(0x1014_85cd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_85d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_85d3, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1014_85d6, 2); if(jaed(0x1014_85e1, 0x9)) goto l_0x1014_85e1; /* jae 0x101485e1 */
            ii(0x1014_85d8, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_85df, 2); jmpd(0x1014_85f3, 0x12); goto l_0x1014_85f3; /* jmp 0x101485f3 */
        l_0x1014_85e1:
            ii(0x1014_85e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_85e4, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1014_85e7, 5); mov(ebx, 0x4a9);                        /* mov ebx, 0x4a9 */
            ii(0x1014_85ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_85ee, 2); div(ebx);                               /* div ebx */
            ii(0x1014_85f0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1014_85f3:
            ii(0x1014_85f3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_85f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_85f8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_85f9, 1); popd(edi);                              /* pop edi */
            ii(0x1014_85fa, 1); popd(esi);                              /* pop esi */
            ii(0x1014_85fb, 1); popd(edx);                              /* pop edx */
            ii(0x1014_85fc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_85fd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_85fe, 1); retd(); return;                         /* ret */
        }
    }
}
