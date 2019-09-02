using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_870a-b1707936")]
        public void Method_100b_870a()
        {
            ii(0x100b_870a, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100b_870f, 5); call(Definitions.sys_check_available_stack_size, 0xa_d63e); /* call 0x10165d52 */
            ii(0x100b_8714, 1); push(ebx);                              /* push ebx */
            ii(0x100b_8715, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8716, 1); push(edx);                              /* push edx */
            ii(0x100b_8717, 1); push(esi);                              /* push esi */
            ii(0x100b_8718, 1); push(edi);                              /* push edi */
            ii(0x100b_8719, 1); push(ebp);                              /* push ebp */
            ii(0x100b_871a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_871c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_8722, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_8725, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_872c, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_8733, 2); jmp(0x100b_873b, 6); goto l_0x100b_873b; /* jmp 0x100b873b */
        l_0x100b_8735:
            ii(0x100b_8735, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_8738, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x100b_873b:
            ii(0x100b_873b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_873e, 5); call(0x1008_a4a0, -0x2_e2a3);           /* call 0x1008a4a0 */
            ii(0x100b_8743, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x100b_8747, 2); if(jle(0x100b_875e, 0x15)) goto l_0x100b_875e; /* jle 0x100b875e */
            ii(0x100b_8749, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100b_874d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_8750, 5); call(0x1008_a3dc, -0x2_e379);           /* call 0x1008a3dc */
            ii(0x100b_8755, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100b_8759, 3); add(memd[ss, ebp - 8], eax);            /* add [ebp-0x8], eax */
            ii(0x100b_875c, 2); jmp(0x100b_8735, -0x29); goto l_0x100b_8735; /* jmp 0x100b8735 */
        l_0x100b_875e:
            ii(0x100b_875e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_8762, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_8764, 2); if(jle(0x100b_87c7, 0x61)) goto l_0x100b_87c7; /* jle 0x100b87c7 */
            ii(0x100b_8766, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100b_876a, 5); call(/* sys */ 0x1016_5e9b, 0xa_d72c);  /* call 0x10165e9b */
            ii(0x100b_876f, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100b_8772, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100b_8775, 1); inc(eax);                               /* inc eax */
            ii(0x100b_8776, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_8779, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_8780, 2); jmp(0x100b_8788, 6); goto l_0x100b_8788; /* jmp 0x100b8788 */
        l_0x100b_8782:
            ii(0x100b_8782, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_8785, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x100b_8788:
            ii(0x100b_8788, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_878b, 5); call(0x1008_a4a0, -0x2_e2f0);           /* call 0x1008a4a0 */
            ii(0x100b_8790, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x100b_8794, 2); if(jle(0x100b_87c7, 0x31)) goto l_0x100b_87c7; /* jle 0x100b87c7 */
            ii(0x100b_8796, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100b_879a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_879d, 5); call(0x1008_a3dc, -0x2_e3c6);           /* call 0x1008a3dc */
            ii(0x100b_87a2, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100b_87a6, 3); sub(memd[ss, ebp - 8], eax);            /* sub [ebp-0x8], eax */
            ii(0x100b_87a9, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_87ad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_87af, 2); if(jg(0x100b_87c5, 0x14)) goto l_0x100b_87c5; /* jg 0x100b87c5 */
            ii(0x100b_87b1, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100b_87b5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_87b8, 5); call(0x1008_a3dc, -0x2_e3e1);           /* call 0x1008a3dc */
            ii(0x100b_87bd, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100b_87c0, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100b_87c3, 2); jmp(0x100b_87ce, 9); goto l_0x100b_87ce; /* jmp 0x100b87ce */
        l_0x100b_87c5:
            ii(0x100b_87c5, 2); jmp(0x100b_8782, -0x45); goto l_0x100b_8782; /* jmp 0x100b8782 */
        l_0x100b_87c7:
            ii(0x100b_87c7, 7); mov(memd[ss, ebp - 16], 0xffff_ffff);   /* mov dword [ebp-0x10], 0xffffffff */
        l_0x100b_87ce:
            ii(0x100b_87ce, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100b_87d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_87d3, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_87d4, 1); pop(edi);                               /* pop edi */
            ii(0x100b_87d5, 1); pop(esi);                               /* pop esi */
            ii(0x100b_87d6, 1); pop(edx);                               /* pop edx */
            ii(0x100b_87d7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_87d8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_87d9, 1); ret();                                  /* ret */
        }
    }
}
