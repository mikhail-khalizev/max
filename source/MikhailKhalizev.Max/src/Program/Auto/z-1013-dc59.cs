using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_dc59-444e3ae5")]
        public void Method_1013_dc59()
        {
            ii(0x1013_dc59, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_dc5e, 5); calld(Definitions.sys_check_available_stack_size, 0x2_80ef); /* call 0x10165d52 */
            ii(0x1013_dc63, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_dc64, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_dc65, 1); pushd(esi);                             /* push esi */
            ii(0x1013_dc66, 1); pushd(edi);                             /* push edi */
            ii(0x1013_dc67, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_dc68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_dc6a, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_dc70, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_dc73, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_dc76, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1013_dc7b, 5); calld(0x1007_5fdc, -0xc_7ca4);          /* call 0x10075fdc */
            ii(0x1013_dc80, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_dc82, 2); if(jnzd(0x1013_dcd7, 0x53)) goto l_0x1013_dcd7; /* jnz 0x1013dcd7 */
            ii(0x1013_dc84, 4); mov(memb_a32[ss, ebp - 0x1a], 0x2);     /* mov byte [ebp-0x1a], 0x2 */
            ii(0x1013_dc88, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_dc8b, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x1013_dc8f, 7); mov(memd_a32[ss, ebp - 0x22], 0x7fff);  /* mov dword [ebp-0x22], 0x7fff */
            ii(0x1013_dc96, 7); mov(memd_a32[ss, ebp - 0x1e], 0x7fff);  /* mov dword [ebp-0x1e], 0x7fff */
            ii(0x1013_dc9d, 7); mov(memd_a32[ss, ebp - 0x19], 0x8000);  /* mov dword [ebp-0x19], 0x8000 */
            ii(0x1013_dca4, 7); mov(memd_a32[ss, ebp - 0x15], 0);       /* mov dword [ebp-0x15], 0x0 */
            ii(0x1013_dcab, 6); mov(memw_a32[ss, ebp - 0x11], 0);       /* mov word [ebp-0x11], 0x0 */
            ii(0x1013_dcb1, 6); mov(memw_a32[ss, ebp - 0xf], 0);        /* mov word [ebp-0xf], 0x0 */
            ii(0x1013_dcb7, 6); mov(memw_a32[ss, ebp - 0xd], 0);        /* mov word [ebp-0xd], 0x0 */
            ii(0x1013_dcbd, 4); mov(memb_a32[ss, ebp - 0xb], 0);        /* mov byte [ebp-0xb], 0x0 */
            ii(0x1013_dcc1, 6); mov(memw_a32[ss, ebp - 0xa], 0xffff);   /* mov word [ebp-0xa], 0xffff */
            ii(0x1013_dcc7, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_dcca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_dccd, 5); calld(0x1013_dfd1, 0x2ff);              /* call 0x1013dfd1 */
            ii(0x1013_dcd2, 5); calld(0x1013_e49e, 0x7c7);              /* call 0x1013e49e */
        l_0x1013_dcd7:
            ii(0x1013_dcd7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_dcd9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_dcda, 1); popd(edi);                              /* pop edi */
            ii(0x1013_dcdb, 1); popd(esi);                              /* pop esi */
            ii(0x1013_dcdc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_dcdd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_dcde, 1); retd(); return;                         /* ret */
        }
    }
}
