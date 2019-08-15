using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b65cc5d6-ced9-4120-90bb-f147077bbdd0")]
        public void Method_1012_034c()
        {
            ii(0x1012_034c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0351, 5); calld(Definitions.sys_check_available_stack_size, 0x4_59fc); /* call 0x10165d52 */
            ii(0x1012_0356, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0357, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0358, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0359, 1); pushd(edi);                             /* push edi */
            ii(0x1012_035a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_035b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_035d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0363, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0366, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0369, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1012_0370, 2); if(jzd(0x1012_0386, 0x14)) goto l_0x1012_0386; /* jz 0x10120386 */
            ii(0x1012_0372, 5); mov(edx, 0x101b_6808);                  /* mov edx, 0x101b6808 */
            ii(0x1012_0377, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_037a, 5); calld(Definitions.sys_call_dtor_arr, 0x4_5c39); /* call 0x10165fb8 */
            ii(0x1012_037f, 5); calld(Definitions.sys_delete_arr, 0x4_5c54); /* call 0x10165fd8 */
            ii(0x1012_0384, 2); jmpd(0x1012_03a7, 0x21); goto l_0x1012_03a7; /* jmp 0x101203a7 */
        l_0x1012_0386:
            ii(0x1012_0386, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_038b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_038e, 5); calld(0x1012_02cc, -0xc7);              /* call 0x101202cc */
            ii(0x1012_0393, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0396, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1012_039d, 2); if(jzd(0x1012_03a7, 0x8)) goto l_0x1012_03a7; /* jz 0x101203a7 */
            ii(0x1012_039f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_03a2, 5); calld(Definitions.sys_delete, 0x4_5bbd); /* call 0x10165f64 */
        l_0x1012_03a7:
            ii(0x1012_03a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_03aa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_03ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_03b0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_03b2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_03b3, 1); popd(edi);                              /* pop edi */
            ii(0x1012_03b4, 1); popd(esi);                              /* pop esi */
            ii(0x1012_03b5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_03b6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_03b7, 1); retd(); return;                         /* ret */
        }
    }
}
