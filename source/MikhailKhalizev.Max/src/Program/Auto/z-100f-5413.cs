using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_5413-432ab3f")]
        public void Method_100f_5413()
        {
            ii(0x100f_5413, 5); push(0x40);                             /* push 0x40 */
            ii(0x100f_5418, 5); call(Definitions.sys_check_available_stack_size, 0x7_0935); /* call 0x10165d52 */
            ii(0x100f_541d, 1); push(ebx);                              /* push ebx */
            ii(0x100f_541e, 1); push(ecx);                              /* push ecx */
            ii(0x100f_541f, 1); push(edx);                              /* push edx */
            ii(0x100f_5420, 1); push(esi);                              /* push esi */
            ii(0x100f_5421, 1); push(edi);                              /* push edi */
            ii(0x100f_5422, 1); push(ebp);                              /* push ebp */
            ii(0x100f_5423, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_5425, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100f_542b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_542e, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_5432, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x100f_5437, 2); if(jg(0x100f_5441, 0x8)) goto l_0x100f_5441; /* jg 0x100f5441 */
            ii(0x100f_5439, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_543d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_543f, 2); if(jge(0x100f_5443, 0x2)) goto l_0x100f_5443; /* jge 0x100f5443 */
        l_0x100f_5441:
            ii(0x100f_5441, 2); jmp(0x100f_5453, 0x10); goto l_0x100f_5453; /* jmp 0x100f5453 */
        l_0x100f_5443:
            ii(0x100f_5443, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5445, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_544a, 5); call(0x1013_ad11, 0x4_58c2);            /* call 0x1013ad11 */
            ii(0x100f_544f, 2); test(al, al);                           /* test al, al */
            ii(0x100f_5451, 2); if(jz(0x100f_5455, 0x2)) goto l_0x100f_5455; /* jz 0x100f5455 */
        l_0x100f_5453:
            ii(0x100f_5453, 2); jmp(0x100f_546f, 0x1a); goto l_0x100f_546f; /* jmp 0x100f546f */
        l_0x100f_5455:
            ii(0x100f_5455, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_545a, 5); call(0x1007_6574, -0x7_eeeb);           /* call 0x10076574 */
            ii(0x100f_545f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_5461, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100f_5464, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5466, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_546b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_546d, 2); if(jz(0x100f_5471, 0x2)) goto l_0x100f_5471; /* jz 0x100f5471 */
        l_0x100f_546f:
            ii(0x100f_546f, 2); jmp(0x100f_5499, 0x28); goto l_0x100f_5499; /* jmp 0x100f5499 */
        l_0x100f_5471:
            ii(0x100f_5471, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5476, 5); call(0x1007_6574, -0x7_ef07);           /* call 0x10076574 */
            ii(0x100f_547b, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100f_547e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_5483, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_5489, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_548f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_5494, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_5497, 2); if(jz(0x100f_54a2, 0x9)) goto l_0x100f_54a2; /* jz 0x100f54a2 */
        l_0x100f_5499:
            ii(0x100f_5499, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_549d, 5); jmp(0x100f_5728, 0x286); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_54a2:
            ii(0x100f_54a2, 7); cmp(memb[ds, 0x101c_391e], 0x9);        /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_54a9, 2); if(jnz(0x100f_54b7, 0xc)) goto l_0x100f_54b7; /* jnz 0x100f54b7 */
            ii(0x100f_54ab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_54ad, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100f_54b2, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_54b5, 2); if(jnz(0x100f_54b9, 0x2)) goto l_0x100f_54b9; /* jnz 0x100f54b9 */
        l_0x100f_54b7:
            ii(0x100f_54b7, 2); jmp(0x100f_54c2, 0x9); goto l_0x100f_54c2; /* jmp 0x100f54c2 */
        l_0x100f_54b9:
            ii(0x100f_54b9, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_54bd, 5); jmp(0x100f_5728, 0x266); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_54c2:
            ii(0x100f_54c2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_54c4, 5); mov(al, memb[ds, 0x101c_37c8]);         /* mov al, [0x101c37c8] */
            ii(0x100f_54c9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_54cf, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_54d5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_54da, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_54dd, 2); if(jnz(0x100f_54e8, 0x9)) goto l_0x100f_54e8; /* jnz 0x100f54e8 */
            ii(0x100f_54df, 7); cmp(memb[ds, 0x101c_391e], 0x7);        /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_54e6, 2); if(jnz(0x100f_54ea, 0x2)) goto l_0x100f_54ea; /* jnz 0x100f54ea */
        l_0x100f_54e8:
            ii(0x100f_54e8, 2); jmp(0x100f_54f3, 0x9); goto l_0x100f_54f3; /* jmp 0x100f54f3 */
        l_0x100f_54ea:
            ii(0x100f_54ea, 7); cmp(memb[ds, 0x101c_37d4], 0);          /* cmp byte [0x101c37d4], 0x0 */
            ii(0x100f_54f1, 2); if(jz(0x100f_54fc, 0x9)) goto l_0x100f_54fc; /* jz 0x100f54fc */
        l_0x100f_54f3:
            ii(0x100f_54f3, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_54f7, 5); jmp(0x100f_5728, 0x22c); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_54fc:
            ii(0x100f_54fc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5501, 5); call(0x1007_6574, -0x7_ef92);           /* call 0x10076574 */
            ii(0x100f_5506, 3); mov(al, memb[ds, eax + 0x3d]);          /* mov al, [eax+0x3d] */
            ii(0x100f_5509, 3); mov(memb[ss, ebp - 0x1c], al);          /* mov [ebp-0x1c], al */
            ii(0x100f_550c, 5); jmp(0x100f_5593, 0x82); goto l_0x100f_5593; /* jmp 0x100f5593 */
        l_0x100f_5511:
            ii(0x100f_5511, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5516, 5); call(0x1007_6574, -0x7_efa7);           /* call 0x10076574 */
            ii(0x100f_551b, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_551f, 2); if(jz(0x100f_552a, 0x9)) goto l_0x100f_552a; /* jz 0x100f552a */
            ii(0x100f_5521, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_5525, 5); jmp(0x100f_5728, 0x1fe); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_552a:
            ii(0x100f_552a, 5); jmp(0x100f_5614, 0xe5); goto l_0x100f_5614; /* jmp 0x100f5614 */
        l_0x100f_552f:
            ii(0x100f_552f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5534, 5); call(0x1007_6574, -0x7_efc5);           /* call 0x10076574 */
            ii(0x100f_5539, 4); cmp(memb[ds, eax + 0x3e], 0xb);         /* cmp byte [eax+0x3e], 0xb */
            ii(0x100f_553d, 2); if(jz(0x100f_5548, 0x9)) goto l_0x100f_5548; /* jz 0x100f5548 */
            ii(0x100f_553f, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_5543, 5); jmp(0x100f_5728, 0x1e0); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_5548:
            ii(0x100f_5548, 5); jmp(0x100f_5614, 0xc7); goto l_0x100f_5614; /* jmp 0x100f5614 */
        l_0x100f_554d:
            ii(0x100f_554d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5552, 5); call(0x1007_6574, -0x7_efe3);           /* call 0x10076574 */
            ii(0x100f_5557, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_555b, 2); if(jz(0x100f_5566, 0x9)) goto l_0x100f_5566; /* jz 0x100f5566 */
            ii(0x100f_555d, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_5561, 5); jmp(0x100f_5728, 0x1c2); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_5566:
            ii(0x100f_5566, 5); jmp(0x100f_5614, 0xa9); goto l_0x100f_5614; /* jmp 0x100f5614 */
        l_0x100f_556b:
            ii(0x100f_556b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5570, 5); call(0x1007_6574, -0x7_f001);           /* call 0x10076574 */
            ii(0x100f_5575, 4); cmp(memb[ds, eax + 0x3e], 0x5);         /* cmp byte [eax+0x3e], 0x5 */
            ii(0x100f_5579, 2); if(jz(0x100f_5584, 0x9)) goto l_0x100f_5584; /* jz 0x100f5584 */
            ii(0x100f_557b, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_557f, 5); jmp(0x100f_5728, 0x1a4); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_5584:
            ii(0x100f_5584, 5); jmp(0x100f_5614, 0x8b); goto l_0x100f_5614; /* jmp 0x100f5614 */
        l_0x100f_5589:
            ii(0x100f_5589, 5); jmp(0x100f_5614, 0x86); goto l_0x100f_5614; /* jmp 0x100f5614 */
        l_0x100f_558e:
            ii(0x100f_558e, 5); jmp(0x100f_5614, 0x81); goto l_0x100f_5614; /* jmp 0x100f5614 */
        l_0x100f_5593:
            ii(0x100f_5593, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x100f_5596, 3); mov(memb[ss, ebp - 0x20], al);          /* mov [ebp-0x20], al */
            ii(0x100f_5599, 4); cmp(memb[ss, ebp - 0x20], 0xc);         /* cmp byte [ebp-0x20], 0xc */
            ii(0x100f_559d, 2); if(jb(0x100f_55d7, 0x38)) goto l_0x100f_55d7; /* jb 0x100f55d7 */
            ii(0x100f_559f, 4); cmp(memb[ss, ebp - 0x20], 0xc);         /* cmp byte [ebp-0x20], 0xc */
            ii(0x100f_55a3, 2); if(jbe(0x100f_5589, -0x1c)) goto l_0x100f_5589; /* jbe 0x100f5589 */
            ii(0x100f_55a5, 4); cmp(memb[ss, ebp - 0x20], 0x1b);        /* cmp byte [ebp-0x20], 0x1b */
            ii(0x100f_55a9, 2); if(jb(0x100f_55cf, 0x24)) goto l_0x100f_55cf; /* jb 0x100f55cf */
            ii(0x100f_55ab, 4); cmp(memb[ss, ebp - 0x20], 0x1b);        /* cmp byte [ebp-0x20], 0x1b */
            ii(0x100f_55af, 6); if(jbe(0x100f_5511, -0xa4)) goto l_0x100f_5511; /* jbe 0x100f5511 */
            ii(0x100f_55b5, 4); cmp(memb[ss, ebp - 0x20], 0x1e);        /* cmp byte [ebp-0x20], 0x1e */
            ii(0x100f_55b9, 2); if(jb(0x100f_55cd, 0x12)) goto l_0x100f_55cd; /* jb 0x100f55cd */
            ii(0x100f_55bb, 4); cmp(memb[ss, ebp - 0x20], 0x1e);        /* cmp byte [ebp-0x20], 0x1e */
            ii(0x100f_55bf, 6); if(jbe(0x100f_5511, -0xb4)) goto l_0x100f_5511; /* jbe 0x100f5511 */
            ii(0x100f_55c5, 4); cmp(memb[ss, ebp - 0x20], 0x1f);        /* cmp byte [ebp-0x20], 0x1f */
            ii(0x100f_55c9, 2); if(jz(0x100f_5589, -0x42)) goto l_0x100f_5589; /* jz 0x100f5589 */
            ii(0x100f_55cb, 2); jmp(0x100f_558e, -0x3f); goto l_0x100f_558e; /* jmp 0x100f558e */
        l_0x100f_55cd:
            ii(0x100f_55cd, 2); jmp(0x100f_558e, -0x41); goto l_0x100f_558e; /* jmp 0x100f558e */
        l_0x100f_55cf:
            ii(0x100f_55cf, 4); cmp(memb[ss, ebp - 0x20], 0x15);        /* cmp byte [ebp-0x20], 0x15 */
            ii(0x100f_55d3, 2); if(jz(0x100f_5589, -0x4c)) goto l_0x100f_5589; /* jz 0x100f5589 */
            ii(0x100f_55d5, 2); jmp(0x100f_558e, -0x49); goto l_0x100f_558e; /* jmp 0x100f558e */
        l_0x100f_55d7:
            ii(0x100f_55d7, 4); cmp(memb[ss, ebp - 0x20], 0x4);         /* cmp byte [ebp-0x20], 0x4 */
            ii(0x100f_55db, 2); if(jb(0x100f_5605, 0x28)) goto l_0x100f_5605; /* jb 0x100f5605 */
            ii(0x100f_55dd, 4); cmp(memb[ss, ebp - 0x20], 0x4);         /* cmp byte [ebp-0x20], 0x4 */
            ii(0x100f_55e1, 6); if(jbe(0x100f_552f, -0xb8)) goto l_0x100f_552f; /* jbe 0x100f552f */
            ii(0x100f_55e7, 4); cmp(memb[ss, ebp - 0x20], 0x7);         /* cmp byte [ebp-0x20], 0x7 */
            ii(0x100f_55eb, 2); if(jb(0x100f_5603, 0x16)) goto l_0x100f_5603; /* jb 0x100f5603 */
            ii(0x100f_55ed, 4); cmp(memb[ss, ebp - 0x20], 0x8);         /* cmp byte [ebp-0x20], 0x8 */
            ii(0x100f_55f1, 6); if(jbe(0x100f_554d, -0xaa)) goto l_0x100f_554d; /* jbe 0x100f554d */
            ii(0x100f_55f7, 4); cmp(memb[ss, ebp - 0x20], 0xb);         /* cmp byte [ebp-0x20], 0xb */
            ii(0x100f_55fb, 6); if(jz(0x100f_556b, -0x96)) goto l_0x100f_556b; /* jz 0x100f556b */
            ii(0x100f_5601, 2); jmp(0x100f_558e, -0x75); goto l_0x100f_558e; /* jmp 0x100f558e */
        l_0x100f_5603:
            ii(0x100f_5603, 2); jmp(0x100f_558e, -0x77); goto l_0x100f_558e; /* jmp 0x100f558e */
        l_0x100f_5605:
            ii(0x100f_5605, 4); cmp(memb[ss, ebp - 0x20], 0x2);         /* cmp byte [ebp-0x20], 0x2 */
            ii(0x100f_5609, 6); if(jz(0x100f_5511, -0xfe)) goto l_0x100f_5511; /* jz 0x100f5511 */
            ii(0x100f_560f, 5); jmp(0x100f_558e, -0x86); goto l_0x100f_558e; /* jmp 0x100f558e */
        l_0x100f_5614:
            ii(0x100f_5614, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100f_5618, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_561a, 5); mov(al, memb[ds, 0x101c_37e4]);         /* mov al, [0x101c37e4] */
            ii(0x100f_561f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_5621, 2); if(jnz(0x100f_5645, 0x22)) goto l_0x100f_5645; /* jnz 0x100f5645 */
            ii(0x100f_5623, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100f_5627, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_562c, 5); call(0x1007_6574, -0x7_f0bd);           /* call 0x10076574 */
            ii(0x100f_5631, 3); mov(ebx, memd[ds, eax + 0xa]);          /* mov ebx, [eax+0xa] */
            ii(0x100f_5634, 5); mov(edx, 0x101c_37e4);                  /* mov edx, 0x101c37e4 */
            ii(0x100f_5639, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_563e, 5); call(0x1007_65d0, -0x7_f073);           /* call 0x100765d0 */
            ii(0x100f_5643, 2); call_abs(memd[ds, ebx]);                /* call dword [ebx] */
        l_0x100f_5645:
            ii(0x100f_5645, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5647, 5); mov(al, memb[ds, 0x101c_37e4]);         /* mov al, [0x101c37e4] */
            ii(0x100f_564c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_564e, 2); if(jnz(0x100f_5659, 0x9)) goto l_0x100f_5659; /* jnz 0x100f5659 */
            ii(0x100f_5650, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_5654, 5); jmp(0x100f_5728, 0xcf); goto l_0x100f_5728; /* jmp 0x100f5728 */
        l_0x100f_5659:
            ii(0x100f_5659, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_565d, 5); call(Definitions.sys_tolower, 0x7_d433); /* call 0x10172a95 */
            ii(0x100f_5662, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_5665, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100f_566c, 2); jmp(0x100f_5674, 0x6); goto l_0x100f_5674; /* jmp 0x100f5674 */
        l_0x100f_566e:
            ii(0x100f_566e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_5671, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x100f_5674:
            ii(0x100f_5674, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100f_5678, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_567a, 5); mov(al, memb[ds, 0x101c_37e4]);         /* mov al, [0x101c37e4] */
            ii(0x100f_567f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_5681, 2); if(jge(0x100f_56c6, 0x43)) goto l_0x100f_56c6; /* jge 0x100f56c6 */
            ii(0x100f_5683, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100f_5687, 6); mov(al, memb[ds, eax + 0x101c_37e5]);   /* mov al, [eax+0x101c37e5] */
            ii(0x100f_568d, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100f_5690, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_5692, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100f_5695, 5); call(Definitions.sys_tolower, 0x7_d3fb); /* call 0x10172a95 */
            ii(0x100f_569a, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_569e, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_56a0, 2); if(jz(0x100f_56c6, 0x24)) goto l_0x100f_56c6; /* jz 0x100f56c6 */
            ii(0x100f_56a2, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100f_56a6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_56a9, 6); mov(eax, memd[ds, eax + 0x101c_37f9]);  /* mov eax, [eax+0x101c37f9] */
            ii(0x100f_56af, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100f_56b1, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100f_56b4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_56b6, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100f_56b9, 5); call(Definitions.sys_tolower, 0x7_d3d7); /* call 0x10172a95 */
            ii(0x100f_56be, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_56c2, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_56c4, 2); if(jnz(0x100f_566e, -0x58)) goto l_0x100f_566e; /* jnz 0x100f566e */
        l_0x100f_56c6:
            ii(0x100f_56c6, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100f_56ca, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_56cc, 5); mov(al, memb[ds, 0x101c_37e4]);         /* mov al, [0x101c37e4] */
            ii(0x100f_56d1, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_56d3, 2); if(jge(0x100f_56db, 0x6)) goto l_0x100f_56db; /* jge 0x100f56db */
            ii(0x100f_56d5, 4); mov(memb[ss, ebp - 0x24], 0x1);         /* mov byte [ebp-0x24], 0x1 */
            ii(0x100f_56d9, 2); jmp(0x100f_56df, 0x4); goto l_0x100f_56df; /* jmp 0x100f56df */
        l_0x100f_56db:
            ii(0x100f_56db, 4); mov(memb[ss, ebp - 0x24], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x100f_56df:
            ii(0x100f_56df, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x100f_56e2, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
            ii(0x100f_56e5, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_56e9, 2); if(jz(0x100f_56f2, 0x7)) goto l_0x100f_56f2; /* jz 0x100f56f2 */
            ii(0x100f_56eb, 7); mov(memb[ds, 0x101c_37e4], 0);          /* mov byte [0x101c37e4], 0x0 */
        l_0x100f_56f2:
            ii(0x100f_56f2, 4); cmp(memb[ss, ebp - 0x8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_56f6, 2); if(jz(0x100f_5722, 0x2a)) goto l_0x100f_5722; /* jz 0x100f5722 */
            ii(0x100f_56f8, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100f_56fd, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_5702, 5); call(0x1013_dc59, 0x4_8552);            /* call 0x1013dc59 */
            ii(0x100f_5707, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x100f_570b, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x100f_570e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_5713, 5); call(0x1007_6600, -0x7_f118);           /* call 0x10076600 */
            ii(0x100f_5718, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_571a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_571c, 6); call_abs(memd[ds, ebx + 0x101c_382b]);  /* call dword [ebx+0x101c382b] */
        l_0x100f_5722:
            ii(0x100f_5722, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100f_5725, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
        l_0x100f_5728:
            ii(0x100f_5728, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x100f_572b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_572d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_572e, 1); pop(edi);                               /* pop edi */
            ii(0x100f_572f, 1); pop(esi);                               /* pop esi */
            ii(0x100f_5730, 1); pop(edx);                               /* pop edx */
            ii(0x100f_5731, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_5732, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_5733, 1); ret();                                  /* ret */
        }
    }
}
