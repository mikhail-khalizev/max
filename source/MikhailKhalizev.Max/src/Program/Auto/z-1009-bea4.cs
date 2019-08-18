using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_bea4-78cb9ba8")]
        public void Method_1009_bea4()
        {
            ii(0x1009_bea4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_bea9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9ea4); /* call 0x10165d52 */
            ii(0x1009_beae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_beaf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_beb0, 1); pushd(esi);                             /* push esi */
            ii(0x1009_beb1, 1); pushd(edi);                             /* push edi */
            ii(0x1009_beb2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_beb3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_beb5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_bebb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bebe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_bec1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bec8, 2); if(jzd(0x1009_bede, 0x14)) goto l_0x1009_bede; /* jz 0x1009bede */
            ii(0x1009_beca, 5); mov(edx, 0x101b_4120);                  /* mov edx, 0x101b4120 */
            ii(0x1009_becf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bed2, 5); calld(Definitions.sys_call_dtor_arr, 0xc_a0e1); /* call 0x10165fb8 */
            ii(0x1009_bed7, 5); calld(Definitions.sys_delete_arr, 0xc_a0fc); /* call 0x10165fd8 */
            ii(0x1009_bedc, 2); jmpd(0x1009_bf12, 0x34); goto l_0x1009_bf12; /* jmp 0x1009bf12 */
        l_0x1009_bede:
            ii(0x1009_bede, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_bee0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bee3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_bee6, 5); calld(0x1009_bbf8, -0x2f3);             /* call 0x1009bbf8 */
            ii(0x1009_beeb, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_beee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bef1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_bef6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bef9, 5); calld(0x100a_284c, 0x694e);             /* call 0x100a284c */
            ii(0x1009_befe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_bf01, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_bf08, 2); if(jzd(0x1009_bf12, 0x8)) goto l_0x1009_bf12; /* jz 0x1009bf12 */
            ii(0x1009_bf0a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bf0d, 5); calld(Definitions.sys_delete, 0xc_a052); /* call 0x10165f64 */
        l_0x1009_bf12:
            ii(0x1009_bf12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_bf15, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_bf18, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_bf1b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_bf1d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_bf1e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_bf1f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_bf20, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_bf21, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_bf22, 1); retd(); return;                         /* ret */
        }
    }
}
