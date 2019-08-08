using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f2ccc054-02c0-4699-b5d6-06b1252b7fb3")]
        public void Method_100c_e71f()
        {
            ii(0x100c_e71f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_e724, 5); calld(Definitions.sys_check_available_stack_size, 0x9_7629); /* call 0x10165d52 */
            ii(0x100c_e729, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_e72a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_e72b, 1); pushd(edx);                             /* push edx */
            ii(0x100c_e72c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_e72d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_e72e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_e72f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e731, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_e737, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_e73a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e73d, 4); cmp(memd_a32[ds, eax + 0xc], 0);        /* cmp dword [eax+0xc], 0x0 */
            ii(0x100c_e741, 2); if(jzd(0x100c_e74e, 0xb)) goto l_0x100c_e74e; /* jz 0x100ce74e */
            ii(0x100c_e743, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e746, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_e749, 5); calld(0x100d_811c, 0x99ce);             /* call 0x100d811c */
        l_0x100c_e74e:
            ii(0x100c_e74e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e751, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_e755, 2); if(jzd(0x100c_e762, 0xb)) goto l_0x100c_e762; /* jz 0x100ce762 */
            ii(0x100c_e757, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e75a, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_e75d, 5); calld(0x100d_811c, 0x99ba);             /* call 0x100d811c */
        l_0x100c_e762:
            ii(0x100c_e762, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e765, 4); cmp(memd_a32[ds, eax + 0x14], 0);       /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_e769, 2); if(jzd(0x100c_e776, 0xb)) goto l_0x100c_e776; /* jz 0x100ce776 */
            ii(0x100c_e76b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e76e, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100c_e771, 5); calld(0x100d_811c, 0x99a6);             /* call 0x100d811c */
        l_0x100c_e776:
            ii(0x100c_e776, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e779, 4); cmp(memd_a32[ds, eax + 0x18], 0);       /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_e77d, 2); if(jzd(0x100c_e78a, 0xb)) goto l_0x100c_e78a; /* jz 0x100ce78a */
            ii(0x100c_e77f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e782, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100c_e785, 5); calld(0x100d_811c, 0x9992);             /* call 0x100d811c */
        l_0x100c_e78a:
            ii(0x100c_e78a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e78c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_e78d, 1); popd(edi);                              /* pop edi */
            ii(0x100c_e78e, 1); popd(esi);                              /* pop esi */
            ii(0x100c_e78f, 1); popd(edx);                              /* pop edx */
            ii(0x100c_e790, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_e791, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_e792, 1); retd(); return;                         /* ret */
        }
    }
}
