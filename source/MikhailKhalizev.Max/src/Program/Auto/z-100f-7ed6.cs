using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_7ed6-de612c09")]
        public void Method_100f_7ed6()
        {
            ii(0x100f_7ed6, 5); push(0x28);                             /* push 0x28 */
            ii(0x100f_7edb, 5); call(Definitions.sys_check_available_stack_size, 0x6_de72); /* call 0x10165d52 */
            ii(0x100f_7ee0, 1); push(ebx);                              /* push ebx */
            ii(0x100f_7ee1, 1); push(ecx);                              /* push ecx */
            ii(0x100f_7ee2, 1); push(esi);                              /* push esi */
            ii(0x100f_7ee3, 1); push(edi);                              /* push edi */
            ii(0x100f_7ee4, 1); push(ebp);                              /* push ebp */
            ii(0x100f_7ee5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7ee7, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_7eed, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_7ef0, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_7ef3, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100f_7ef6, 5); call(Definitions.my_ctor_0x101b_4184, -0x8_140b); /* call 0x10076af0 */
            ii(0x100f_7efb, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_7eff, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_7f02, 2); if(jl(0x100f_7f0d, 0x9)) goto l_0x100f_7f0d; /* jl 0x100f7f0d */
            ii(0x100f_7f04, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_7f08, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_7f0b, 2); if(jge(0x100f_7f0f, 0x2)) goto l_0x100f_7f0f; /* jge 0x100f7f0f */
        l_0x100f_7f0d:
            ii(0x100f_7f0d, 2); jmp(0x100f_7f23, 0x14); goto l_0x100f_7f23; /* jmp 0x100f7f23 */
        l_0x100f_7f0f:
            ii(0x100f_7f0f, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_7f13, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100f_7f19, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_7f1c, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100f_7f1f, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_7f21, 2); if(jle(0x100f_7f25, 0x2)) goto l_0x100f_7f25; /* jle 0x100f7f25 */
        l_0x100f_7f23:
            ii(0x100f_7f23, 2); jmp(0x100f_7f39, 0x14); goto l_0x100f_7f39; /* jmp 0x100f7f39 */
        l_0x100f_7f25:
            ii(0x100f_7f25, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_7f29, 6); mov(edx, memd[ds, 0x101c_8172]);        /* mov edx, [0x101c8172] */
            ii(0x100f_7f2f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_7f32, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100f_7f35, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_7f37, 2); if(jle(0x100f_7f42, 0x9)) goto l_0x100f_7f42; /* jle 0x100f7f42 */
        l_0x100f_7f39:
            ii(0x100f_7f39, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_7f3d, 5); jmp(0x100f_7fa7, 0x65); goto l_0x100f_7fa7; /* jmp 0x100f7fa7 */
        l_0x100f_7f42:
            ii(0x100f_7f42, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_7f45, 1); dec(eax);                               /* dec eax */
            ii(0x100f_7f46, 4); mov(memw[ss, ebp - 0x10], ax);          /* mov [ebp-0x10], ax */
            ii(0x100f_7f4a, 2); jmp(0x100f_7f53, 0x7); goto l_0x100f_7f53; /* jmp 0x100f7f53 */
        l_0x100f_7f4c:
            ii(0x100f_7f4c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7f4f, 4); inc(memw[ss, ebp - 0x10]);              /* inc word [ebp-0x10] */
        l_0x100f_7f53:
            ii(0x100f_7f53, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_7f57, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100f_7f5b, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100f_7f5e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_7f60, 2); if(jge(0x100f_7fa3, 0x41)) goto l_0x100f_7fa3; /* jge 0x100f7fa3 */
            ii(0x100f_7f62, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7f65, 1); dec(eax);                               /* dec eax */
            ii(0x100f_7f66, 4); mov(memw[ss, ebp - 0xe], ax);           /* mov [ebp-0xe], ax */
            ii(0x100f_7f6a, 2); jmp(0x100f_7f73, 0x7); goto l_0x100f_7f73; /* jmp 0x100f7f73 */
        l_0x100f_7f6c:
            ii(0x100f_7f6c, 3); mov(eax, memd[ss, ebp - 0xe]);          /* mov eax, [ebp-0xe] */
            ii(0x100f_7f6f, 4); inc(memw[ss, ebp - 0xe]);               /* inc word [ebp-0xe] */
        l_0x100f_7f73:
            ii(0x100f_7f73, 4); movsx(edx, memw[ss, ebp - 0xe]);        /* movsx edx, word [ebp-0xe] */
            ii(0x100f_7f77, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_7f7b, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100f_7f7e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_7f80, 2); if(jge(0x100f_7fa1, 0x1f)) goto l_0x100f_7fa1; /* jge 0x100f7fa1 */
            ii(0x100f_7f82, 4); movsx(edx, memw[ss, ebp - 0xe]);        /* movsx edx, word [ebp-0xe] */
            ii(0x100f_7f86, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_7f8a, 5); call(0x1007_3d48, -0x8_4247);           /* call 0x10073d48 */
            ii(0x100f_7f8f, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100f_7f94, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_7f97, 2); if(jz(0x100f_7f9f, 0x6)) goto l_0x100f_7f9f; /* jz 0x100f7f9f */
            ii(0x100f_7f99, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_7f9d, 2); jmp(0x100f_7fa7, 0x8); goto l_0x100f_7fa7; /* jmp 0x100f7fa7 */
        l_0x100f_7f9f:
            ii(0x100f_7f9f, 2); jmp(0x100f_7f6c, -0x35); goto l_0x100f_7f6c; /* jmp 0x100f7f6c */
        l_0x100f_7fa1:
            ii(0x100f_7fa1, 2); jmp(0x100f_7f4c, -0x57); goto l_0x100f_7f4c; /* jmp 0x100f7f4c */
        l_0x100f_7fa3:
            ii(0x100f_7fa3, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x100f_7fa7:
            ii(0x100f_7fa7, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100f_7faa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_7fac, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_7fad, 1); pop(edi);                               /* pop edi */
            ii(0x100f_7fae, 1); pop(esi);                               /* pop esi */
            ii(0x100f_7faf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_7fb0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_7fb1, 1); ret();                                  /* ret */
        }
    }
}
