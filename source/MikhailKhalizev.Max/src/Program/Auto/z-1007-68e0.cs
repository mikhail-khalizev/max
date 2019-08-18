using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("658bbfc9-c3aa-41c5-ad32-b3d0039669ad")]
        public void Method_1007_68e0()
        {
            ii(0x1007_68e0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_68e5, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f468); /* call 0x10165d52 */
            ii(0x1007_68ea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_68eb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_68ec, 1); pushd(edx);                             /* push edx */
            ii(0x1007_68ed, 1); pushd(esi);                             /* push esi */
            ii(0x1007_68ee, 1); pushd(edi);                             /* push edi */
            ii(0x1007_68ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_68f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_68f2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_68f8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_68fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_68fe, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_6900, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6903, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6906, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6908, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6909, 1); popd(edi);                              /* pop edi */
            ii(0x1007_690a, 1); popd(esi);                              /* pop esi */
            ii(0x1007_690b, 1); popd(edx);                              /* pop edx */
            ii(0x1007_690c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_690d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_690e, 1); retd(); return;                         /* ret */
        }
    }
}
