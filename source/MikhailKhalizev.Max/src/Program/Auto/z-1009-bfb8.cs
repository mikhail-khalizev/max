using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_bfb8-febc2e8a")]
        public void Method_1009_bfb8()
        {
            ii(0x1009_bfb8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_bfbd, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9d90); /* call 0x10165d52 */
            ii(0x1009_bfc2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_bfc3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_bfc4, 1); pushd(esi);                             /* push esi */
            ii(0x1009_bfc5, 1); pushd(edi);                             /* push edi */
            ii(0x1009_bfc6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_bfc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_bfc9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bfcf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bfd2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_bfd5, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bfdc, 2); if(jzd(0x1009_bff2, 0x14)) goto l_0x1009_bff2; /* jz 0x1009bff2 */
            ii(0x1009_bfde, 5); mov(edx, 0x101b_4148);                  /* mov edx, 0x101b4148 */
            ii(0x1009_bfe3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bfe6, 5); calld(Definitions.sys_call_dtor_arr, 0xc_9fcd); /* call 0x10165fb8 */
            ii(0x1009_bfeb, 5); calld(Definitions.sys_delete_arr, 0xc_9fe8); /* call 0x10165fd8 */
            ii(0x1009_bff0, 2); jmpd(0x1009_c013, 0x21); goto l_0x1009_c013; /* jmp 0x1009c013 */
        l_0x1009_bff2:
            ii(0x1009_bff2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bff7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bffa, 5); calld(0x1009_bf24, -0xdb);              /* call 0x1009bf24 */
            ii(0x1009_bfff, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c002, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_c009, 2); if(jzd(0x1009_c013, 0x8)) goto l_0x1009_c013; /* jz 0x1009c013 */
            ii(0x1009_c00b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c00e, 5); calld(Definitions.sys_delete, 0xc_9f51); /* call 0x10165f64 */
        l_0x1009_c013:
            ii(0x1009_c013, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c016, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c019, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c01c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c01e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c01f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c020, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c021, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c022, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c023, 1); retd();                                 /* ret */
        }
    }
}
