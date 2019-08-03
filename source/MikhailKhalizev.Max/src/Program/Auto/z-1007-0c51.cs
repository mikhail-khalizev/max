using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6f2f2bb7-ff4a-412a-b7c3-3d69bd59a020")]
        public void Method_1007_0c51()
        {
            ii(0x1007_0c51, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_0c56, 5); calld(Definitions.sys_check_available_stack_size, 0xf50f7); /* call 0x10165d52 */
            ii(0x1007_0c5b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_0c5c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_0c5d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_0c5e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_0c5f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_0c60, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_0c62, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_0c68, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_0c6b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_0c6e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_0c71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0c74, 5); calld(0x1007_6a6c, 0x5df3);             /* call 0x10076a6c */
            ii(0x1007_0c79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0c7c, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x1007_0c80, 5); imul(dx, memw_a32[ds, eax + 0x2]);      /* imul dx, [eax+0x2] */
            ii(0x1007_0c85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0c88, 3); mov(bx, memw_a32[ds, eax]);             /* mov bx, [eax] */
            ii(0x1007_0c8b, 4); imul(bx, memw_a32[ds, eax]);            /* imul bx, [eax] */
            ii(0x1007_0c8f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_0c91, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_0c93, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_0c96, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_0c99, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_0c9b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_0c9c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_0c9d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_0c9e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_0c9f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_0ca0, 1); retd(); return;                         /* ret */
        }
    }
}
