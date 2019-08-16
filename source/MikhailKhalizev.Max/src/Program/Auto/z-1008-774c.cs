using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("99c44416-9526-4abd-b7fc-866f17ae0ba8")]
        public void Method_1008_774c()
        {
            ii(0x1008_774c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_7751, 5); calld(Definitions.sys_check_available_stack_size, 0xd_e5fc); /* call 0x10165d52 */
            ii(0x1008_7756, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7757, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7758, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7759, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_775a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_775c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_7762, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_7765, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1008_7768, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1008_776b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_776e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_7771, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1008_7775, 2); if(jnzd(0x1008_778b, 0x14)) goto l_0x1008_778b; /* jnz 0x1008778b */
            ii(0x1008_7777, 5); mov(ebx, 0x1008_774c);                  /* mov ebx, 0x1008774c */
            ii(0x1008_777c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1008_777f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7782, 5); calld(0x1007_8d4a, -0xea3d);            /* call 0x10078d4a */
            ii(0x1008_7787, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7789, 2); if(jnzd(0x1008_7796, 0xb)) goto l_0x1008_7796; /* jnz 0x10087796 */
        l_0x1008_778b:
            ii(0x1008_778b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_778e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_7791, 5); calld(0x1008_785d, 0xc7);               /* call 0x1008785d */
        l_0x1008_7796:
            ii(0x1008_7796, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7798, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_7799, 1); popd(edi);                              /* pop edi */
            ii(0x1008_779a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_779b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_779c, 1); retd(); return;                         /* ret */
        }
    }
}