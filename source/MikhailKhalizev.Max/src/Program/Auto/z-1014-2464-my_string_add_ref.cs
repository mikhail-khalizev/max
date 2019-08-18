using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b054b7be-5b63-4527-9902-cfe5a33dd182")]
        public void my_string_add_ref()
        {
            ii(0x1014_2464, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_2469, 5); calld(Definitions.sys_check_available_stack_size, 0x2_38e4); /* call 0x10165d52 */
            ii(0x1014_246e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_246f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_2470, 1); pushd(edx);                             /* push edx */
            ii(0x1014_2471, 1); pushd(esi);                             /* push esi */
            ii(0x1014_2472, 1); pushd(edi);                             /* push edi */
            ii(0x1014_2473, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_2474, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2476, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_247c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_247f, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_2483, 2); if(jzd(0x1014_248b, 0x6)) goto l_0x1014_248b; /* jz 0x1014248b */
            ii(0x1014_2485, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_2488, 3); inc(memd_a32[ds, eax + 0x8]);           /* inc dword [eax+0x8] */
        l_0x1014_248b:
            ii(0x1014_248b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_248d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_248e, 1); popd(edi);                              /* pop edi */
            ii(0x1014_248f, 1); popd(esi);                              /* pop esi */
            ii(0x1014_2490, 1); popd(edx);                              /* pop edx */
            ii(0x1014_2491, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_2492, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_2493, 1); retd(); return;                         /* ret */
        }
    }
}
