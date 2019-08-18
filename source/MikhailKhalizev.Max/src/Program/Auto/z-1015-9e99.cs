using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9e99-5c52c83e")]
        public void Method_1015_9e99()
        {
            ii(0x1015_9e99, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_9e9e, 5); calld(Definitions.sys_check_available_stack_size, 0xbeaf); /* call 0x10165d52 */
            ii(0x1015_9ea3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_9ea4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_9ea5, 1); pushd(esi);                             /* push esi */
            ii(0x1015_9ea6, 1); pushd(edi);                             /* push edi */
            ii(0x1015_9ea7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_9ea8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9eaa, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_9eb0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_9eb3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_9eb6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_9eb9, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1015_9ebd, 2); if(jnzd(0x1015_9edb, 0x1c)) goto l_0x1015_9edb; /* jnz 0x10159edb */
            ii(0x1015_9ebf, 5); mov(eax, 0x1015_9680);                  /* mov eax, 0x10159680 */
            ii(0x1015_9ec4, 1); pushd(eax);                             /* push eax */
            ii(0x1015_9ec5, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1015_9eca, 5); mov(ebx, StringDefinitions.Start8);     /* mov ebx, 0x101b26a3 */
            ii(0x1015_9ecf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9ed1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_9ed4, 5); calld(0x1015_7ccf, -0x220a);            /* call 0x10157ccf */
            ii(0x1015_9ed9, 2); jmpd(0x1015_9ef5, 0x1a); goto l_0x1015_9ef5; /* jmp 0x10159ef5 */
        l_0x1015_9edb:
            ii(0x1015_9edb, 5); mov(eax, 0x1015_9712);                  /* mov eax, 0x10159712 */
            ii(0x1015_9ee0, 1); pushd(eax);                             /* push eax */
            ii(0x1015_9ee1, 5); mov(ecx, 0x37);                         /* mov ecx, 0x37 */
            ii(0x1015_9ee6, 5); mov(ebx, StringDefinitions.Stop8);      /* mov ebx, 0x101b26a9 */
            ii(0x1015_9eeb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9eed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_9ef0, 5); calld(0x1015_7ccf, -0x2226);            /* call 0x10157ccf */
        l_0x1015_9ef5:
            ii(0x1015_9ef5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_9ef8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_9efb, 5); calld(0x1015_8bbb, -0x1345);            /* call 0x10158bbb */
            ii(0x1015_9f00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9f02, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_9f03, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9f04, 1); popd(esi);                              /* pop esi */
            ii(0x1015_9f05, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_9f06, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_9f07, 1); retd(); return;                         /* ret */
        }
    }
}
