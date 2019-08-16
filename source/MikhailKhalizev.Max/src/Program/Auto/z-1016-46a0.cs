using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4ebcea14-d2de-4325-8ba2-f312e9ac1e0a")]
        public void Method_1016_46a0()
        {
            ii(0x1016_46a0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_46a5, 5); calld(Definitions.sys_check_available_stack_size, 0x16a8); /* call 0x10165d52 */
            ii(0x1016_46aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_46ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_46ac, 1); pushd(esi);                             /* push esi */
            ii(0x1016_46ad, 1); pushd(edi);                             /* push edi */
            ii(0x1016_46ae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_46af, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_46b1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_46b7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_46ba, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_46bd, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1016_46c4, 2); if(jzd(0x1016_46da, 0x14)) goto l_0x1016_46da; /* jz 0x101646da */
            ii(0x1016_46c6, 5); mov(edx, 0x101b_74c8);                  /* mov edx, 0x101b74c8 */
            ii(0x1016_46cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_46ce, 5); calld(Definitions.sys_call_dtor_arr, 0x18e5); /* call 0x10165fb8 */
            ii(0x1016_46d3, 5); calld(Definitions.sys_delete_arr, 0x1900); /* call 0x10165fd8 */
            ii(0x1016_46d8, 2); jmpd(0x1016_46fb, 0x21); goto l_0x1016_46fb; /* jmp 0x101646fb */
        l_0x1016_46da:
            ii(0x1016_46da, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_46df, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_46e2, 5); calld(0x100c_d916, -0x9_6dd1);          /* call 0x100cd916 */
            ii(0x1016_46e7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_46ea, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1016_46f1, 2); if(jzd(0x1016_46fb, 0x8)) goto l_0x1016_46fb; /* jz 0x101646fb */
            ii(0x1016_46f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_46f6, 5); calld(Definitions.sys_delete, 0x1869);  /* call 0x10165f64 */
        l_0x1016_46fb:
            ii(0x1016_46fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_46fe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4701, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_4704, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4706, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4707, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4708, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4709, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_470a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_470b, 1); retd(); return;                         /* ret */
        }
    }
}