using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_6804-fccb0a4e")]
        public void Method_1008_6804()
        {
            ii(0x1008_6804, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_6809, 5); calld(Definitions.sys_check_available_stack_size, 0xd_f544); /* call 0x10165d52 */
            ii(0x1008_680e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_680f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_6810, 1); pushd(esi);                             /* push esi */
            ii(0x1008_6811, 1); pushd(edi);                             /* push edi */
            ii(0x1008_6812, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_6813, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_6815, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_681b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_681e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_6821, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_6824, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1008_6828, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_682b, 4); cmp(dx, memw_a32[ds, eax + 0x1e]);      /* cmp dx, [eax+0x1e] */
            ii(0x1008_682f, 2); if(jnzd(0x1008_6841, 0x10)) goto l_0x1008_6841; /* jnz 0x10086841 */
            ii(0x1008_6831, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_6834, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1008_6838, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_683b, 4); cmp(dx, memw_a32[ds, eax + 0x20]);      /* cmp dx, [eax+0x20] */
            ii(0x1008_683f, 2); if(jzd(0x1008_6843, 0x2)) goto l_0x1008_6843; /* jz 0x10086843 */
        l_0x1008_6841:
            ii(0x1008_6841, 2); jmpd(0x1008_6849, 0x6); goto l_0x1008_6849; /* jmp 0x10086849 */
        l_0x1008_6843:
            ii(0x1008_6843, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_6847, 2); jmpd(0x1008_684d, 0x4); goto l_0x1008_684d; /* jmp 0x1008684d */
        l_0x1008_6849:
            ii(0x1008_6849, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_684d:
            ii(0x1008_684d, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_6850, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1008_6853, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1008_6856, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_6858, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_6859, 1); popd(edi);                              /* pop edi */
            ii(0x1008_685a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_685b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_685c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_685d, 1); retd();                                 /* ret */
        }
    }
}
