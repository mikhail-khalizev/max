using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_013b-c418e1ba")]
        public void Method_1016_013b()
        {
            ii(0x1016_013b, 5); push(0x20);                             /* push 0x20 */
            ii(0x1016_0140, 5); call(Definitions.sys_check_available_stack_size, 0x5c0d); /* call 0x10165d52 */
            ii(0x1016_0145, 1); push(ebx);                              /* push ebx */
            ii(0x1016_0146, 1); push(ecx);                              /* push ecx */
            ii(0x1016_0147, 1); push(edx);                              /* push edx */
            ii(0x1016_0148, 1); push(esi);                              /* push esi */
            ii(0x1016_0149, 1); push(edi);                              /* push edi */
            ii(0x1016_014a, 1); push(ebp);                              /* push ebp */
            ii(0x1016_014b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_014d, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1016_0153, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1016_0156, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0158, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_015b, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1016_015e, 5); call(0x1007_6a34, -0xe_972f);           /* call 0x10076a34 */
            ii(0x1016_0163, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0166, 4); test(memb[ds, eax + 0x12], 0x20);       /* test byte [eax+0x12], 0x20 */
            ii(0x1016_016a, 2); if(jz(0x1016_0186, 0x1a)) goto l_0x1016_0186; /* jz 0x10160186 */
            ii(0x1016_016c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_016f, 5); call(0x1016_0038, -0x13c);              /* call 0x10160038 */
            ii(0x1016_0174, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0176, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0179, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1016_017c, 5); call(0x1007_6a34, -0xe_974d);           /* call 0x10076a34 */
            ii(0x1016_0181, 5); jmp(0x1016_027a, 0xf4); goto l_0x1016_027a; /* jmp 0x1016027a */
        l_0x1016_0186:
            ii(0x1016_0186, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0189, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1016_018c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0191, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_0197, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1016_019d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_01a2, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1016_01a5, 2); if(jnz(0x1016_01b3, 0xc)) goto l_0x1016_01b3; /* jnz 0x101601b3 */
            ii(0x1016_01a7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_01aa, 4); mov(memb[ds, eax + 0x3e], 0x2a);        /* mov byte [eax+0x3e], 0x2a */
            ii(0x1016_01ae, 5); jmp(0x1016_027a, 0xc7); goto l_0x1016_027a; /* jmp 0x1016027a */
        l_0x1016_01b3:
            ii(0x1016_01b3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_01b6, 4); cmp(memb[ds, eax + 0x3e], 0x1c);        /* cmp byte [eax+0x3e], 0x1c */
            ii(0x1016_01ba, 2); if(jnz(0x1016_021c, 0x60)) goto l_0x1016_021c; /* jnz 0x1016021c */
            ii(0x1016_01bc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_01bf, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1016_01c3, 2); if(jz(0x1016_01ce, 9)) goto l_0x1016_01ce; /* jz 0x101601ce */
            ii(0x1016_01c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_01c8, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1016_01cc, 2); if(jnz(0x1016_01d0, 2)) goto l_0x1016_01d0; /* jnz 0x101601d0 */
        l_0x1016_01ce:
            ii(0x1016_01ce, 2); jmp(0x1016_0202, 0x32); goto l_0x1016_0202; /* jmp 0x10160202 */
        l_0x1016_01d0:
            ii(0x1016_01d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_01d3, 5); call(0x1011_9138, -0x4_70a0);           /* call 0x10119138 */
            ii(0x1016_01d8, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1016_01db, 3); add(ebx, 0x65);                         /* add ebx, 0x65 */
            ii(0x1016_01de, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_01e0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_01e2, 5); call(0x1007_6a34, -0xe_97b3);           /* call 0x10076a34 */
            ii(0x1016_01e7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_01ea, 5); call(0x1014_f08b, -0x1_1164);           /* call 0x1014f08b */
            ii(0x1016_01ef, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1016_01f6, 2); if(jz(0x1016_0200, 8)) goto l_0x1016_0200; /* jz 0x10160200 */
            ii(0x1016_01f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_01fb, 5); call(0x1012_ae8d, -0x3_5373);           /* call 0x1012ae8d */
        l_0x1016_0200:
            ii(0x1016_0200, 2); jmp(0x1016_021a, 0x18); goto l_0x1016_021a; /* jmp 0x1016021a */
        l_0x1016_0202:
            ii(0x1016_0202, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1016_0207, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_020a, 5); call(0x1011_b7de, -0x4_4a31);           /* call 0x1011b7de */
            ii(0x1016_020f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_0211, 2); if(jz(0x1016_021a, 7)) goto l_0x1016_021a; /* jz 0x1016021a */
            ii(0x1016_0213, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0216, 4); mov(memb[ds, eax + 0x3e], 0x1d);        /* mov byte [eax+0x3e], 0x1d */
        l_0x1016_021a:
            ii(0x1016_021a, 2); jmp(0x1016_027a, 0x5e); goto l_0x1016_027a; /* jmp 0x1016027a */
        l_0x1016_021c:
            ii(0x1016_021c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_021f, 5); call(0x1007_61d4, -0xe_a050);           /* call 0x100761d4 */
            ii(0x1016_0224, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_0226, 2); if(jz(0x1016_0237, 0xf)) goto l_0x1016_0237; /* jz 0x10160237 */
            ii(0x1016_0228, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_022d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0230, 5); call(0x1007_31cf, -0xe_d066);           /* call 0x100731cf */
            ii(0x1016_0235, 2); jmp(0x1016_027a, 0x43); goto l_0x1016_027a; /* jmp 0x1016027a */
        l_0x1016_0237:
            ii(0x1016_0237, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_023a, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1016_023e, 2); if(jz(0x1016_0249, 9)) goto l_0x1016_0249; /* jz 0x10160249 */
            ii(0x1016_0240, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0243, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1016_0247, 2); if(jnz(0x1016_024b, 2)) goto l_0x1016_024b; /* jnz 0x1016024b */
        l_0x1016_0249:
            ii(0x1016_0249, 2); jmp(0x1016_0262, 0x17); goto l_0x1016_0262; /* jmp 0x10160262 */
        l_0x1016_024b:
            ii(0x1016_024b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_024e, 5); call(0x1011_9138, -0x4_711b);           /* call 0x10119138 */
            ii(0x1016_0253, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_0255, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0258, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1016_025b, 5); call(0x1007_6a34, -0xe_982c);           /* call 0x10076a34 */
            ii(0x1016_0260, 2); jmp(0x1016_027a, 0x18); goto l_0x1016_027a; /* jmp 0x1016027a */
        l_0x1016_0262:
            ii(0x1016_0262, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1016_0267, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_026a, 5); call(0x1011_b7de, -0x4_4a91);           /* call 0x1011b7de */
            ii(0x1016_026f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_0271, 2); if(jz(0x1016_027a, 7)) goto l_0x1016_027a; /* jz 0x1016027a */
            ii(0x1016_0273, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0276, 4); mov(memb[ds, eax + 0x3e], 0x2a);        /* mov byte [eax+0x3e], 0x2a */
        l_0x1016_027a:
            ii(0x1016_027a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_027c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_027d, 1); pop(edi);                               /* pop edi */
            ii(0x1016_027e, 1); pop(esi);                               /* pop esi */
            ii(0x1016_027f, 1); pop(edx);                               /* pop edx */
            ii(0x1016_0280, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_0281, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_0282, 1); ret();                                  /* ret */
        }
    }
}
