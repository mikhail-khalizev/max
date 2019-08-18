using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a758bb5d-41a0-4d70-a7bd-6d1f81483583")]
        public void Method_1009_ef13()
        {
            ii(0x1009_ef13, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1009_ef18, 5); calld(Definitions.sys_check_available_stack_size, 0xc_6e35); /* call 0x10165d52 */
            ii(0x1009_ef1d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ef1e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ef1f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ef20, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ef21, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ef23, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_ef29, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_ef2c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ef2f, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_ef32, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_ef35, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1009_ef38, 5); calld(0x1007_5e64, -0x2_90d9);          /* call 0x10075e64 */
            ii(0x1009_ef3d, 1); pushd(eax);                             /* push eax */
            ii(0x1009_ef3e, 5); mov(ecx, 0x2000);                       /* mov ecx, 0x2000 */
            ii(0x1009_ef43, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_ef45, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1009_ef49, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ef4c, 5); calld(0x1009_cc08, -0x2349);            /* call 0x1009cc08 */
            ii(0x1009_ef51, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_ef54, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_ef57, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_ef5a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ef5d, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4948); /* mov dword [eax+0x2], 0x101b4948 */
            ii(0x1009_ef64, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ef67, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_ef6a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_ef6d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ef6f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ef70, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ef71, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ef72, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ef73, 1); retd(); return;                         /* ret */
        }
    }
}
