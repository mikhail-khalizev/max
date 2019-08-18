using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90419d13-cb59-4ab1-8a93-8ba2d4d84bac")]
        public void Method_1012_ac41()
        {
            ii(0x1012_ac41, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_ac46, 5); calld(Definitions.sys_check_available_stack_size, 0x3_b107); /* call 0x10165d52 */
            ii(0x1012_ac4b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_ac4c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_ac4d, 1); pushd(edx);                             /* push edx */
            ii(0x1012_ac4e, 1); pushd(esi);                             /* push esi */
            ii(0x1012_ac4f, 1); pushd(edi);                             /* push edi */
            ii(0x1012_ac50, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_ac51, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_ac53, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_ac59, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_ac5c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_ac5f, 5); mov(memd_a32[ds, 0x101c_59cc], eax);    /* mov [0x101c59cc], eax */
            ii(0x1012_ac64, 7); mov(memb_a32[ds, 0x101c_5630], 0x1);    /* mov byte [0x101c5630], 0x1 */
            ii(0x1012_ac6b, 5); mov(eax, memd_a32[ds, 0x101c_59cc]);    /* mov eax, [0x101c59cc] */
            ii(0x1012_ac70, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1012_ac74, 2); if(jzd(0x1012_ac7d, 0x7)) goto l_0x1012_ac7d; /* jz 0x1012ac7d */
            ii(0x1012_ac76, 5); calld(0x1012_a96a, -0x311);             /* call 0x1012a96a */
            ii(0x1012_ac7b, 2); jmpd(0x1012_ac8b, 0xe); goto l_0x1012_ac8b; /* jmp 0x1012ac8b */
        l_0x1012_ac7d:
            ii(0x1012_ac7d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_ac7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_ac81, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1012_ac86, 5); calld(0x1012_aad5, -0x1b6);             /* call 0x1012aad5 */
        l_0x1012_ac8b:
            ii(0x1012_ac8b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_ac8d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_ac8e, 1); popd(edi);                              /* pop edi */
            ii(0x1012_ac8f, 1); popd(esi);                              /* pop esi */
            ii(0x1012_ac90, 1); popd(edx);                              /* pop edx */
            ii(0x1012_ac91, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_ac92, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_ac93, 1); retd(); return;                         /* ret */
        }
    }
}
