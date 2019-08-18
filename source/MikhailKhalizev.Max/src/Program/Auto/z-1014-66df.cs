using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("556a9fed-539b-4a0b-b49c-d4686f1c0b7d")]
        public void Method_1014_66df()
        {
            ii(0x1014_66df, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_66e4, 5); calld(Definitions.sys_check_available_stack_size, 0x1_f669); /* call 0x10165d52 */
            ii(0x1014_66e9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_66ea, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_66eb, 1); pushd(edx);                             /* push edx */
            ii(0x1014_66ec, 1); pushd(esi);                             /* push esi */
            ii(0x1014_66ed, 1); pushd(edi);                             /* push edi */
            ii(0x1014_66ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_66ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_66f1, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_66f7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_66fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_66fd, 5); calld(0x1013_ba3c, -0xacc6);            /* call 0x1013ba3c */
            ii(0x1014_6702, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6704, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6707, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_670a, 5); calld(0x1014_7b94, 0x1485);             /* call 0x10147b94 */
            ii(0x1014_670f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6712, 7); mov(memd_a32[ds, eax + 0x1c], 0xffff_ffff); /* mov dword [eax+0x1c], 0xffffffff */
            ii(0x1014_6719, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_671b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_671c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_671d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_671e, 1); popd(edx);                              /* pop edx */
            ii(0x1014_671f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_6720, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_6721, 1); retd(); return;                         /* ret */
        }
    }
}
