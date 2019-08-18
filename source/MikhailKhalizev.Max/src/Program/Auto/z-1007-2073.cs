using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("64638505-3ce1-4c11-8305-07be4c12e61d")]
        public void Method_1007_2073()
        {
            ii(0x1007_2073, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_2078, 5); calld(Definitions.sys_check_available_stack_size, 0xf_3cd5); /* call 0x10165d52 */
            ii(0x1007_207d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_207e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_207f, 1); pushd(edx);                             /* push edx */
            ii(0x1007_2080, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2081, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2082, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2083, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2085, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_208b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_208e, 5); cmp(memw_a32[ss, ebp - 0x4], 0);        /* cmp word [ebp-0x4], 0x0 */
            ii(0x1007_2093, 2); if(jnzd(0x1007_209e, 0x9)) goto l_0x1007_209e; /* jnz 0x1007209e */
            ii(0x1007_2095, 7); mov(memd_a32[ss, ebp - 0x8], 0x5);      /* mov dword [ebp-0x8], 0x5 */
            ii(0x1007_209c, 2); jmpd(0x1007_20a5, 0x7); goto l_0x1007_20a5; /* jmp 0x100720a5 */
        l_0x1007_209e:
            ii(0x1007_209e, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1007_20a5:
            ii(0x1007_20a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_20a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_20aa, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_20ab, 1); popd(edi);                              /* pop edi */
            ii(0x1007_20ac, 1); popd(esi);                              /* pop esi */
            ii(0x1007_20ad, 1); popd(edx);                              /* pop edx */
            ii(0x1007_20ae, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_20af, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_20b0, 1); retd(); return;                         /* ret */
        }
    }
}
