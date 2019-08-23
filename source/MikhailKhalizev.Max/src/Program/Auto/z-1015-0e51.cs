using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_0e51-6cfb62a6")]
        public void Method_1015_0e51()
        {
            ii(0x1015_0e51, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1015_0e56, 5); call(Definitions.sys_check_available_stack_size, 0x1_4ef7); /* call 0x10165d52 */
            ii(0x1015_0e5b, 1); push(ebx);                              /* push ebx */
            ii(0x1015_0e5c, 1); push(ecx);                              /* push ecx */
            ii(0x1015_0e5d, 1); push(edx);                              /* push edx */
            ii(0x1015_0e5e, 1); push(esi);                              /* push esi */
            ii(0x1015_0e5f, 1); push(edi);                              /* push edi */
            ii(0x1015_0e60, 1); push(ebp);                              /* push ebp */
            ii(0x1015_0e61, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0e63, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_0e69, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_0e6c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0e6f, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x1015_0e73, 2); if(jnz(0x1015_0e7e, 0x9)) goto l_0x1015_0e7e; /* jnz 0x10150e7e */
            ii(0x1015_0e75, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_0e79, 5); jmp(0x1015_0f9e, 0x120); goto l_0x1015_0f9e; /* jmp 0x10150f9e */
        l_0x1015_0e7e:
            ii(0x1015_0e7e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0e81, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1015_0e84, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_0e87, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0e8a, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_0e8d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_0e92, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x1015_0e98, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1015_0e9d, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_0e9f, 5); call(0x100d_fd2c, -0x7_1178);           /* call 0x100dfd2c */
            ii(0x1015_0ea4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_0ea7, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_0eaa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0ead, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0eb0, 5); call(0x1007_6e00, -0xd_a0b5);           /* call 0x10076e00 */
            ii(0x1015_0eb5, 2); test(al, al);                           /* test al, al */
            ii(0x1015_0eb7, 2); if(jz(0x1015_0ec2, 0x9)) goto l_0x1015_0ec2; /* jz 0x10150ec2 */
            ii(0x1015_0eb9, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_0ebd, 5); jmp(0x1015_0f9e, 0xdc); goto l_0x1015_0f9e; /* jmp 0x10150f9e */
        l_0x1015_0ec2:
            ii(0x1015_0ec2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0ec5, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0ec8, 5); call(0x1007_6730, -0xd_a79d);           /* call 0x10076730 */
            ii(0x1015_0ecd, 4); mov(dx, memw[ds, eax + 0xa]);           /* mov dx, [eax+0xa] */
            ii(0x1015_0ed1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0ed4, 4); cmp(dx, memw[ds, eax + 0xa]);           /* cmp dx, [eax+0xa] */
            ii(0x1015_0ed8, 2); if(jl(0x1015_0ef2, 0x18)) goto l_0x1015_0ef2; /* jl 0x10150ef2 */
            ii(0x1015_0eda, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0edd, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0ee0, 5); call(0x1007_6730, -0xd_a7b5);           /* call 0x10076730 */
            ii(0x1015_0ee5, 4); mov(dx, memw[ds, eax + 0xe]);           /* mov dx, [eax+0xe] */
            ii(0x1015_0ee9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0eec, 4); cmp(dx, memw[ds, eax + 0xe]);           /* cmp dx, [eax+0xe] */
            ii(0x1015_0ef0, 2); if(jge(0x1015_0ef4, 0x2)) goto l_0x1015_0ef4; /* jge 0x10150ef4 */
        l_0x1015_0ef2:
            ii(0x1015_0ef2, 2); jmp(0x1015_0f0c, 0x18); goto l_0x1015_0f0c; /* jmp 0x10150f0c */
        l_0x1015_0ef4:
            ii(0x1015_0ef4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0ef7, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0efa, 5); call(0x1007_6730, -0xd_a7cf);           /* call 0x10076730 */
            ii(0x1015_0eff, 4); mov(dx, memw[ds, eax + 0xc]);           /* mov dx, [eax+0xc] */
            ii(0x1015_0f03, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0f06, 4); cmp(dx, memw[ds, eax + 0xc]);           /* cmp dx, [eax+0xc] */
            ii(0x1015_0f0a, 2); if(jge(0x1015_0f0e, 0x2)) goto l_0x1015_0f0e; /* jge 0x10150f0e */
        l_0x1015_0f0c:
            ii(0x1015_0f0c, 2); jmp(0x1015_0f26, 0x18); goto l_0x1015_0f26; /* jmp 0x10150f26 */
        l_0x1015_0f0e:
            ii(0x1015_0f0e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0f11, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0f14, 5); call(0x1007_6730, -0xd_a7e9);           /* call 0x10076730 */
            ii(0x1015_0f19, 4); mov(dx, memw[ds, eax + 0x10]);          /* mov dx, [eax+0x10] */
            ii(0x1015_0f1d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0f20, 4); cmp(dx, memw[ds, eax + 0x10]);          /* cmp dx, [eax+0x10] */
            ii(0x1015_0f24, 2); if(jge(0x1015_0f28, 0x2)) goto l_0x1015_0f28; /* jge 0x10150f28 */
        l_0x1015_0f26:
            ii(0x1015_0f26, 2); jmp(0x1015_0f40, 0x18); goto l_0x1015_0f40; /* jmp 0x10150f40 */
        l_0x1015_0f28:
            ii(0x1015_0f28, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0f2b, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0f2e, 5); call(0x1007_6730, -0xd_a803);           /* call 0x10076730 */
            ii(0x1015_0f33, 4); mov(dx, memw[ds, eax + 0x12]);          /* mov dx, [eax+0x12] */
            ii(0x1015_0f37, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0f3a, 4); cmp(dx, memw[ds, eax + 0x12]);          /* cmp dx, [eax+0x12] */
            ii(0x1015_0f3e, 2); if(jge(0x1015_0f42, 0x2)) goto l_0x1015_0f42; /* jge 0x10150f42 */
        l_0x1015_0f40:
            ii(0x1015_0f40, 2); jmp(0x1015_0f5a, 0x18); goto l_0x1015_0f5a; /* jmp 0x10150f5a */
        l_0x1015_0f42:
            ii(0x1015_0f42, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0f45, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0f48, 5); call(0x1007_6730, -0xd_a81d);           /* call 0x10076730 */
            ii(0x1015_0f4d, 4); mov(dx, memw[ds, eax + 0x14]);          /* mov dx, [eax+0x14] */
            ii(0x1015_0f51, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0f54, 4); cmp(dx, memw[ds, eax + 0x14]);          /* cmp dx, [eax+0x14] */
            ii(0x1015_0f58, 2); if(jge(0x1015_0f5c, 0x2)) goto l_0x1015_0f5c; /* jge 0x10150f5c */
        l_0x1015_0f5a:
            ii(0x1015_0f5a, 2); jmp(0x1015_0f74, 0x18); goto l_0x1015_0f74; /* jmp 0x10150f74 */
        l_0x1015_0f5c:
            ii(0x1015_0f5c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0f5f, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0f62, 5); call(0x1007_6730, -0xd_a837);           /* call 0x10076730 */
            ii(0x1015_0f67, 4); mov(dx, memw[ds, eax + 0x17]);          /* mov dx, [eax+0x17] */
            ii(0x1015_0f6b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0f6e, 4); cmp(dx, memw[ds, eax + 0x17]);          /* cmp dx, [eax+0x17] */
            ii(0x1015_0f72, 2); if(jge(0x1015_0f76, 0x2)) goto l_0x1015_0f76; /* jge 0x10150f76 */
        l_0x1015_0f74:
            ii(0x1015_0f74, 2); jmp(0x1015_0f8e, 0x18); goto l_0x1015_0f8e; /* jmp 0x10150f8e */
        l_0x1015_0f76:
            ii(0x1015_0f76, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0f79, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_0f7c, 5); call(0x1007_6730, -0xd_a851);           /* call 0x10076730 */
            ii(0x1015_0f81, 4); mov(dx, memw[ds, eax + 0x1b]);          /* mov dx, [eax+0x1b] */
            ii(0x1015_0f85, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_0f88, 4); cmp(dx, memw[ds, eax + 0x1b]);          /* cmp dx, [eax+0x1b] */
            ii(0x1015_0f8c, 2); if(jge(0x1015_0f94, 0x6)) goto l_0x1015_0f94; /* jge 0x10150f94 */
        l_0x1015_0f8e:
            ii(0x1015_0f8e, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_0f92, 2); jmp(0x1015_0f98, 0x4); goto l_0x1015_0f98; /* jmp 0x10150f98 */
        l_0x1015_0f94:
            ii(0x1015_0f94, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1015_0f98:
            ii(0x1015_0f98, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1015_0f9b, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
        l_0x1015_0f9e:
            ii(0x1015_0f9e, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1015_0fa1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_0fa3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_0fa4, 1); pop(edi);                               /* pop edi */
            ii(0x1015_0fa5, 1); pop(esi);                               /* pop esi */
            ii(0x1015_0fa6, 1); pop(edx);                               /* pop edx */
            ii(0x1015_0fa7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_0fa8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_0fa9, 1); ret();                                  /* ret */
        }
    }
}
