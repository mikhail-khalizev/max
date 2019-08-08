using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dd34a087-f90b-4f58-baa9-85c96180ba5a")]
        public void my_dtor_d6()
        {
            ii(0x100e_b0d7, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100e_b0dc, 5); calld(Definitions.sys_check_available_stack_size, 0x7_ac71); /* call 0x10165d52 */
            ii(0x100e_b0e1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b0e2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b0e3, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b0e4, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b0e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b0e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b0e8, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_b0ee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_b0f1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_b0f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b0f7, 5); calld(0x100e_b226, 0x12a);              /* call 0x100eb226 */
            ii(0x100e_b0fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b0ff, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x100e_b102, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_b105, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100e_b109, 2); if(jzd(0x100e_b11f, 0x14)) goto l_0x100e_b11f; /* jz 0x100eb11f */
            ii(0x100e_b10b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_b10d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_b110, 5); calld(Definitions.my_dtor_d3, -0x1_33e2); /* call 0x100d7d33 */
            ii(0x100e_b115, 5); calld(Definitions.sys_delete, 0x7_ae4a); /* call 0x10165f64 */
            ii(0x100e_b11a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_b11d, 2); jmpd(0x100e_b126, 0x7); goto l_0x100e_b126; /* jmp 0x100eb126 */
        l_0x100e_b11f:
            ii(0x100e_b11f, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x100e_b126:
            ii(0x100e_b126, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b129, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b12c, 5); calld(Definitions.sys_delete, 0x7_ae33); /* call 0x10165f64 */
            ii(0x100e_b131, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b134, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100e_b137, 5); calld(Definitions.sys_delete, 0x7_ae28); /* call 0x10165f64 */
            ii(0x100e_b13c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b13f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_b142, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_b145, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b147, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b148, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b149, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b14a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b14b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b14c, 1); retd(); return;                         /* ret */
        }
    }
}
