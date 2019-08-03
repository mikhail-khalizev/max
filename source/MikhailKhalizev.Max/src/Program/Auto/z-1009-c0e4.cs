using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cbcf44e9-c13b-4c4d-8bfb-6cb588d7d7e2")]
        public void Method_1009_c0e4()
        {
            ii(0x1009_c0e4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c0e9, 5); calld(Definitions.sys_check_available_stack_size, 0xc9c64); /* call 0x10165d52 */
            ii(0x1009_c0ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c0ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c0f0, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c0f1, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c0f2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c0f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c0f5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c0fb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c0fe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c101, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_c108, 2); if(jzd(0x1009_c11e, 0x14)) goto l_0x1009_c11e; /* jz 0x1009c11e */
            ii(0x1009_c10a, 5); mov(edx, 0x101b_41ac);                  /* mov edx, 0x101b41ac */
            ii(0x1009_c10f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c112, 5); calld(Definitions.sys_call_dtor_arr, 0xc9ea1); /* call 0x10165fb8 */
            ii(0x1009_c117, 5); calld(Definitions.sys_delete_arr, 0xc9ebc); /* call 0x10165fd8 */
            ii(0x1009_c11c, 2); jmpd(0x1009_c13f, 0x21); goto l_0x1009_c13f; /* jmp 0x1009c13f */
        l_0x1009_c11e:
            ii(0x1009_c11e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_c123, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c126, 5); calld(0x100c_d916, 0x317eb);            /* call 0x100cd916 */
            ii(0x1009_c12b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c12e, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_c135, 2); if(jzd(0x1009_c13f, 0x8)) goto l_0x1009_c13f; /* jz 0x1009c13f */
            ii(0x1009_c137, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c13a, 5); calld(Definitions.sys_delete, 0xc9e25); /* call 0x10165f64 */
        l_0x1009_c13f:
            ii(0x1009_c13f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c142, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c145, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c148, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c14a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c14b, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c14c, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c14d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c14e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c14f, 1); retd(); return;                         /* ret */
        }
    }
}
