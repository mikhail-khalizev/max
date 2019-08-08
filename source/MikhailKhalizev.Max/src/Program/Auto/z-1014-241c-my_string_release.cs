using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("97866ab2-5b75-4673-8682-a59dc35418b7")]
        public void my_string_release()
        {
            ii(0x1014_241c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_2421, 5); calld(Definitions.sys_check_available_stack_size, 0x2_392c); /* call 0x10165d52 */
            ii(0x1014_2426, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_2427, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_2428, 1); pushd(edx);                             /* push edx */
            ii(0x1014_2429, 1); pushd(esi);                             /* push esi */
            ii(0x1014_242a, 1); pushd(edi);                             /* push edi */
            ii(0x1014_242b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_242c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_242e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_2434, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_2437, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_243b, 2); if(jzd(0x1014_245b, 0x1e)) goto l_0x1014_245b; /* jz 0x1014245b */
            ii(0x1014_243d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_2440, 3); dec(memd_a32[ds, eax + 0x8]);           /* dec dword [eax+0x8] */
            ii(0x1014_2443, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_2446, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x1014_244a, 2); if(jnzd(0x1014_245b, 0xf)) goto l_0x1014_245b; /* jnz 0x1014245b */
            ii(0x1014_244c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_244e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_2451, 5); calld(Definitions.my_strobj_dtor, -0xbbc); /* call 0x1014189a */
            ii(0x1014_2456, 5); calld(Definitions.sys_delete, 0x2_3b09); /* call 0x10165f64 */
        l_0x1014_245b:
            ii(0x1014_245b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_245d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_245e, 1); popd(edi);                              /* pop edi */
            ii(0x1014_245f, 1); popd(esi);                              /* pop esi */
            ii(0x1014_2460, 1); popd(edx);                              /* pop edx */
            ii(0x1014_2461, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_2462, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_2463, 1); retd(); return;                         /* ret */
        }
    }
}
