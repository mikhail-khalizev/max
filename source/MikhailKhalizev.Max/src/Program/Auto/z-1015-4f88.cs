using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_4f88-ebd368b1")]
        public void Method_1015_4f88()
        {
            ii(0x1015_4f88, 5); push(0x34);                             /* push 0x34 */
            ii(0x1015_4f8d, 5); call(Definitions.sys_check_available_stack_size, 0x1_0dc0); /* call 0x10165d52 */
            ii(0x1015_4f92, 1); push(esi);                              /* push esi */
            ii(0x1015_4f93, 1); push(edi);                              /* push edi */
            ii(0x1015_4f94, 1); push(ebp);                              /* push ebp */
            ii(0x1015_4f95, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_4f97, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_4f9d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_4fa0, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_4fa3, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1015_4fa6, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1015_4fa9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_4fac, 3); mov(al, memb[ds, eax + 0x45]);          /* mov al, [eax+0x45] */
            ii(0x1015_4faf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4fb4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_4fb6, 2); if(jle(0x1015_4fc8, 0x10)) goto l_0x1015_4fc8; /* jle 0x10154fc8 */
            ii(0x1015_4fb8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_4fbb, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_4fbe, 5); call(Definitions.my_2_get_count, -0xc_9c5b); /* call 0x1008b368 */
            ii(0x1015_4fc3, 1); cwde();                                 /* cwde */
            ii(0x1015_4fc4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_4fc6, 2); if(jg(0x1015_4fca, 0x2)) goto l_0x1015_4fca; /* jg 0x10154fca */
        l_0x1015_4fc8:
            ii(0x1015_4fc8, 2); jmp(0x1015_4fe0, 0x16); goto l_0x1015_4fe0; /* jmp 0x10154fe0 */
        l_0x1015_4fca:
            ii(0x1015_4fca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4fcc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_4fcf, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_4fd2, 5); call(0x1008_b228, -0xc_9daf);           /* call 0x1008b228 */
            ii(0x1015_4fd7, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1015_4fda, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1015_4fde, 2); if(jz(0x1015_4fe2, 0x2)) goto l_0x1015_4fe2; /* jz 0x10154fe2 */
        l_0x1015_4fe0:
            ii(0x1015_4fe0, 2); jmp(0x1015_4fef, 0xd); goto l_0x1015_4fef; /* jmp 0x10154fef */
        l_0x1015_4fe2:
            ii(0x1015_4fe2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_4fe4, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1015_4fe7, 3); mov(al, memb[ds, edx + 0x45]);          /* mov al, [edx+0x45] */
            ii(0x1015_4fea, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_4fed, 2); jmp(0x1015_5017, 0x28); goto l_0x1015_5017; /* jmp 0x10155017 */
        l_0x1015_4fef:
            ii(0x1015_4fef, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1015_4ff3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_4ff6, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_4ff9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4ffe, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_5004, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1015_5009, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_500b, 5); call(0x100d_fd2c, -0x7_52e4);           /* call 0x100dfd2c */
            ii(0x1015_5010, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1015_5014, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x1015_5017:
            ii(0x1015_5017, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_501a, 4); test(memb[ds, eax + 0x13], 0x1);        /* test byte [eax+0x13], 0x1 */
            ii(0x1015_501e, 2); if(jz(0x1015_502c, 0xc)) goto l_0x1015_502c; /* jz 0x1015502c */
            ii(0x1015_5020, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_5023, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1015_5027, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_502a, 2); jmp(0x1015_5033, 0x7); goto l_0x1015_5033; /* jmp 0x10155033 */
        l_0x1015_502c:
            ii(0x1015_502c, 7); mov(memd[ss, ebp - 0x18], 0x7fff);      /* mov dword [ebp-0x18], 0x7fff */
        l_0x1015_5033:
            ii(0x1015_5033, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_5036, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x1015_503b, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x1015_5042:
            ii(0x1015_5042, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1015_5046, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_5048, 2); if(jle(0x1015_50ab, 0x61)) goto l_0x1015_50ab; /* jle 0x101550ab */
            ii(0x1015_504a, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1015_504e, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1015_5052, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_5055, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_5058, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_505b, 5); call(0x100d_4c69, -0x8_03f7);           /* call 0x100d4c69 */
            ii(0x1015_5060, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1015_5063, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1015_5067, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_506b, 5); call(Definitions.my_min, -0xc_b8ec);    /* call 0x10089784 */
            ii(0x1015_5070, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_5073, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1015_5077, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_507a, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_507d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_5080, 5); call(0x1007_1e00, -0xe_3285);           /* call 0x10071e00 */
            ii(0x1015_5085, 3); add(memd[ss, ebp - 0x1c], eax);         /* add [ebp-0x1c], eax */
            ii(0x1015_5088, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_508b, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
            ii(0x1015_508e, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1015_5092, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_5095, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_5098, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_509b, 5); call(0x1007_1e00, -0xe_32a0);           /* call 0x10071e00 */
            ii(0x1015_50a0, 3); sub(memd[ss, ebp - 0x18], eax);         /* sub [ebp-0x18], eax */
            ii(0x1015_50a3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_50a6, 3); sub(memd[ss, ebp - 0x14], eax);         /* sub [ebp-0x14], eax */
            ii(0x1015_50a9, 2); jmp(0x1015_5042, -0x69); goto l_0x1015_5042; /* jmp 0x10155042 */
        l_0x1015_50ab:
            ii(0x1015_50ab, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_50ae, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1015_50b1, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1015_50b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_50b6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_50b7, 1); pop(edi);                               /* pop edi */
            ii(0x1015_50b8, 1); pop(esi);                               /* pop esi */
            ii(0x1015_50b9, 1); ret();                                  /* ret */
        }
    }
}
