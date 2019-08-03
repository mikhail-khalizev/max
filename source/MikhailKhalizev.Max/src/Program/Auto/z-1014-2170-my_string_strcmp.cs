using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b63cd685-4d7c-4af4-85a7-c40296b3317b")]
        public void my_string_strcmp()
        {
            ii(0x1014_2170, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_2175, 5); calld(Definitions.sys_check_available_stack_size, 0x23bd8); /* call 0x10165d52 */
            ii(0x1014_217a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_217b, 1); pushd(esi);                             /* push esi */
            ii(0x1014_217c, 1); pushd(edi);                             /* push edi */
            ii(0x1014_217d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_217e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2180, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_2186, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_2189, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_218c, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1014_218f, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1014_2193, 2); if(jzd(0x1014_21ac, 0x17)) goto l_0x1014_21ac; /* jz 0x101421ac */
            ii(0x1014_2195, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_2198, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_219b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_219d, 5); calld(Definitions.my_strobj_c_str, -0xb89a6); /* call 0x100897fc */
            ii(0x1014_21a2, 5); calld(Definitions.sys_strcmp, 0x305e9); /* call 0x10172790 */
            ii(0x1014_21a7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_21aa, 2); jmpd(0x1014_21c1, 0x15); goto l_0x1014_21c1; /* jmp 0x101421c1 */
        l_0x1014_21ac:
            ii(0x1014_21ac, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_21af, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_21b2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_21b4, 5); calld(Definitions.my_strobj_c_str, -0xb89bd); /* call 0x100897fc */
            ii(0x1014_21b9, 5); calld(Definitions.sys_strcasecmp, 0x23f72); /* call 0x10166130 */
            ii(0x1014_21be, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1014_21c1:
            ii(0x1014_21c1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_21c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_21c6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_21c7, 1); popd(edi);                              /* pop edi */
            ii(0x1014_21c8, 1); popd(esi);                              /* pop esi */
            ii(0x1014_21c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_21ca, 1); retd(); return;                         /* ret */
        }
    }
}
