using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_5463-1551106b")]
        public void Method_1009_5463()
        {
            ii(0x1009_5463, 5); push(0x44);                             /* push 0x44 */
            ii(0x1009_5468, 5); call(Definitions.sys_check_available_stack_size, 0xd_08e5); /* call 0x10165d52 */
            ii(0x1009_546d, 1); push(ebx);                              /* push ebx */
            ii(0x1009_546e, 1); push(ecx);                              /* push ecx */
            ii(0x1009_546f, 1); push(edx);                              /* push edx */
            ii(0x1009_5470, 1); push(esi);                              /* push esi */
            ii(0x1009_5471, 1); push(edi);                              /* push edi */
            ii(0x1009_5472, 1); push(ebp);                              /* push ebp */
            ii(0x1009_5473, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_5475, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1009_547b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_547e, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_5482, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_5485, 5); call(0x1009_41f2, -0x1298);             /* call 0x100941f2 */
            ii(0x1009_548a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_548c, 2); if(jz(0x1009_54e9, 0x5b)) goto l_0x1009_54e9; /* jz 0x100954e9 */
            ii(0x1009_548e, 5); call(0x1008_a7bc, -0xacd7);             /* call 0x1008a7bc */
            ii(0x1009_5493, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_5498, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_549b, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1009_54a0, 5); call(Definitions.sys_new, 0xd_095b);    /* call 0x10165e00 */
            ii(0x1009_54a5, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_54a8, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_54ab, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_54ae, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1009_54b2, 2); if(jz(0x1009_54ca, 0x16)) goto l_0x1009_54ca; /* jz 0x100954ca */
            ii(0x1009_54b4, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_54b7, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_54ba, 5); call(0x100a_3711, 0xe252);              /* call 0x100a3711 */
            ii(0x1009_54bf, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_54c2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_54c5, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_54c8, 2); jmp(0x1009_54d0, 0x6); goto l_0x1009_54d0; /* jmp 0x100954d0 */
        l_0x1009_54ca:
            ii(0x1009_54ca, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_54cd, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1009_54d0:
            ii(0x1009_54d0, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1009_54d3, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_54d8, 3); mov(ebx, memd[ss, ebp - 0x10]);         /* mov ebx, [ebp-0x10] */
            ii(0x1009_54db, 5); call(0x100a_4db6, 0xf8d6);              /* call 0x100a4db6 */
            ii(0x1009_54e0, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_54e4, 5); jmp(0x1009_55c7, 0xde); goto l_0x1009_55c7; /* jmp 0x100955c7 */
        l_0x1009_54e9:
            ii(0x1009_54e9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_54ec, 5); call(0x1009_497a, -0xb77);              /* call 0x1009497a */
            ii(0x1009_54f1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_54f4, 3); mov(eax, memd[ds, eax + 0x2b]);         /* mov eax, [eax+0x2b] */
            ii(0x1009_54f7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_54fa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_54fc, 2); if(jl(0x1009_550b, 0xd)) goto l_0x1009_550b; /* jl 0x1009550b */
            ii(0x1009_54fe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_5501, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x1009_5504, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5507, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_5509, 2); if(jge(0x1009_550d, 0x2)) goto l_0x1009_550d; /* jge 0x1009550d */
        l_0x1009_550b:
            ii(0x1009_550b, 2); jmp(0x1009_551e, 0x11); goto l_0x1009_551e; /* jmp 0x1009551e */
        l_0x1009_550d:
            ii(0x1009_550d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_5510, 3); mov(eax, memd[ds, eax + 0x29]);         /* mov eax, [eax+0x29] */
            ii(0x1009_5513, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5516, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_5518, 6); if(jge(0x1009_55c1, 0xa3)) goto l_0x1009_55c1; /* jge 0x100955c1 */
        l_0x1009_551e:
            ii(0x1009_551e, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_5523, 5); call(0x1007_6338, -0x1_f1f0);           /* call 0x10076338 */
            ii(0x1009_5528, 3); lea(ebx, memd[ss, ebp - 0x24]);         /* lea ebx, [ebp-0x24] */
            ii(0x1009_552b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_552d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_552f, 5); call(0x1007_64b8, -0x1_f07c);           /* call 0x100764b8 */
            ii(0x1009_5534, 2); jmp(0x1009_553e, 0x8); goto l_0x1009_553e; /* jmp 0x1009553e */
        l_0x1009_5536:
            ii(0x1009_5536, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_5539, 5); call(0x1007_6bf8, -0x1_e946);           /* call 0x10076bf8 */
        l_0x1009_553e:
            ii(0x1009_553e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5540, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_5543, 5); call(0x1013_ad71, 0xa_5829);            /* call 0x1013ad71 */
            ii(0x1009_5548, 2); test(al, al);                           /* test al, al */
            ii(0x1009_554a, 2); if(jz(0x1009_557b, 0x2f)) goto l_0x1009_557b; /* jz 0x1009557b */
            ii(0x1009_554c, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_554f, 5); call(0x1007_63a0, -0x1_f1b4);           /* call 0x100763a0 */
            ii(0x1009_5554, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5556, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1009_5559, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_555c, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_555f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5562, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_5564, 2); if(jnz(0x1009_5575, 0xf)) goto l_0x1009_5575; /* jnz 0x10095575 */
            ii(0x1009_5566, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_5569, 5); call(0x1007_63a0, -0x1_f1ce);           /* call 0x100763a0 */
            ii(0x1009_556e, 5); cmp(memw[ds, eax + 0x8], 0x28);         /* cmp word [eax+0x8], 0x28 */
            ii(0x1009_5573, 2); if(jz(0x1009_5577, 0x2)) goto l_0x1009_5577; /* jz 0x10095577 */
        l_0x1009_5575:
            ii(0x1009_5575, 2); jmp(0x1009_5579, 0x2); goto l_0x1009_5579; /* jmp 0x10095579 */
        l_0x1009_5577:
            ii(0x1009_5577, 2); jmp(0x1009_557b, 0x2); goto l_0x1009_557b; /* jmp 0x1009557b */
        l_0x1009_5579:
            ii(0x1009_5579, 2); jmp(0x1009_5536, -0x45); goto l_0x1009_5536; /* jmp 0x10095536 */
        l_0x1009_557b:
            ii(0x1009_557b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_557d, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_5580, 5); call(0x1013_ad11, 0xa_578c);            /* call 0x1013ad11 */
            ii(0x1009_5585, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5587, 2); if(jz(0x1009_5592, 0x9)) goto l_0x1009_5592; /* jz 0x10095592 */
            ii(0x1009_5589, 7); mov(memd[ss, ebp - 0x28], 0x500);       /* mov dword [ebp-0x28], 0x500 */
            ii(0x1009_5590, 2); jmp(0x1009_5599, 0x7); goto l_0x1009_5599; /* jmp 0x10095599 */
        l_0x1009_5592:
            ii(0x1009_5592, 7); mov(memd[ss, ebp - 0x28], 0xe00);       /* mov dword [ebp-0x28], 0xe00 */
        l_0x1009_5599:
            ii(0x1009_5599, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_559c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_559f, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_55a2, 5); mov(edx, 0x28);                         /* mov edx, 0x28 */
            ii(0x1009_55a7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_55aa, 5); call(0x1009_6e02, 0x1853);              /* call 0x10096e02 */
            ii(0x1009_55af, 2); test(al, al);                           /* test al, al */
            ii(0x1009_55b1, 2); if(jz(0x1009_55b7, 0x4)) goto l_0x1009_55b7; /* jz 0x100955b7 */
            ii(0x1009_55b3, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
        l_0x1009_55b7:
            ii(0x1009_55b7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_55b9, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_55bc, 5); call(0x1007_5f6c, -0x1_f655);           /* call 0x10075f6c */
        l_0x1009_55c1:
            ii(0x1009_55c1, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_55c4, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x1009_55c7:
            ii(0x1009_55c7, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1009_55ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_55cc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_55cd, 1); pop(edi);                               /* pop edi */
            ii(0x1009_55ce, 1); pop(esi);                               /* pop esi */
            ii(0x1009_55cf, 1); pop(edx);                               /* pop edx */
            ii(0x1009_55d0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_55d1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_55d2, 1); ret();                                  /* ret */
        }
    }
}
