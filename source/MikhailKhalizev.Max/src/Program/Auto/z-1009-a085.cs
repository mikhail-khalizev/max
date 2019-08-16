using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ad20219c-41dc-4d07-8888-650d6219db39")]
        public void Method_1009_a085()
        {
            ii(0x1009_a085, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1009_a08a, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bcc3); /* call 0x10165d52 */
            ii(0x1009_a08f, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a090, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a091, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a092, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a094, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_a09a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_a09d, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_a0a0, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_a0a3, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_a0a6, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_a0aa, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1009_a0ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_a0b0, 5); calld(0x1008_ad90, -0xf325);            /* call 0x1008ad90 */
            ii(0x1009_a0b5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_a0b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_a0bb, 5); calld(0x100a_26d1, 0x8611);             /* call 0x100a26d1 */
            ii(0x1009_a0c0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_a0c3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1009_a0c6, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_a0c9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_a0cc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a0cf, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x2_39e4); /* call 0x100766f0 */
            ii(0x1009_a0d4, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_a0d7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_a0da, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1009_a0dd, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_a0e0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_a0e3, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_a0e6, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x2_39fb); /* call 0x100766f0 */
            ii(0x1009_a0eb, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x1009_a0ee, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_a0f1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1009_a0f4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_a0f7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_a0fa, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_42cc); /* mov dword [eax+0x2], 0x101b42cc */
            ii(0x1009_a101, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_a104, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_a107, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_a10a, 5); calld(0x1007_6630, -0x2_3adf);          /* call 0x10076630 */
            ii(0x1009_a10f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_a112, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_a115, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_a118, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a11a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a11b, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a11c, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a11d, 1); retd(); return;                         /* ret */
        }
    }
}