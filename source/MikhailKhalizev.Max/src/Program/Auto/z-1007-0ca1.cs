using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7751d66-163d-4bf9-9b48-bc6bb4abdc2d")]
        public void Method_1007_0ca1()
        {
            ii(0x1007_0ca1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_0ca6, 5); calld(Definitions.sys_check_available_stack_size, 0xf50a7); /* call 0x10165d52 */
            ii(0x1007_0cab, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_0cac, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_0cad, 1); pushd(esi);                             /* push esi */
            ii(0x1007_0cae, 1); pushd(edi);                             /* push edi */
            ii(0x1007_0caf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_0cb0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_0cb2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_0cb8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_0cbb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_0cbe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0cc1, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1007_0cc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_0cc8, 3); sub(memw_a32[ds, eax], dx);             /* sub [eax], dx */
            ii(0x1007_0ccb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0cce, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1007_0cd2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_0cd5, 4); sub(memw_a32[ds, eax + 0x2], dx);       /* sub [eax+0x2], dx */
            ii(0x1007_0cd9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_0cdc, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x1007_0ce0, 5); imul(dx, memw_a32[ds, eax + 0x2]);      /* imul dx, [eax+0x2] */
            ii(0x1007_0ce5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_0ce8, 3); mov(bx, memw_a32[ds, eax]);             /* mov bx, [eax] */
            ii(0x1007_0ceb, 4); imul(bx, memw_a32[ds, eax]);            /* imul bx, [eax] */
            ii(0x1007_0cef, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_0cf1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_0cf3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_0cf6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_0cf9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_0cfb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_0cfc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_0cfd, 1); popd(esi);                              /* pop esi */
            ii(0x1007_0cfe, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_0cff, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_0d00, 1); retd(); return;                         /* ret */
        }
    }
}