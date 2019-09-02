using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_f947-a6d4293d")]
        public void Method_1008_f947()
        {
            ii(0x1008_f947, 5); push(0x30);                             /* push 0x30 */
            ii(0x1008_f94c, 5); call(Definitions.sys_check_available_stack_size, 0xd_6401); /* call 0x10165d52 */
            ii(0x1008_f951, 1); push(ebx);                              /* push ebx */
            ii(0x1008_f952, 1); push(ecx);                              /* push ecx */
            ii(0x1008_f953, 1); push(esi);                              /* push esi */
            ii(0x1008_f954, 1); push(edi);                              /* push edi */
            ii(0x1008_f955, 1); push(ebp);                              /* push ebp */
            ii(0x1008_f956, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_f958, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_f95e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_f961, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_f964, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_f966, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_f969, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_f96c, 5); call(0x1013_ad11, 0xa_b3a0);            /* call 0x1013ad11 */
            ii(0x1008_f971, 2); test(al, al);                           /* test al, al */
            ii(0x1008_f973, 2); if(jnz(0x1008_f98d, 0x18)) goto l_0x1008_f98d; /* jnz 0x1008f98d */
            ii(0x1008_f975, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_f978, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_f97b, 5); call(0x1007_6574, -0x1_940c);           /* call 0x10076574 */
            ii(0x1008_f980, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x1008_f984, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_f987, 4); cmp(dx, memw[ds, eax + 8]);             /* cmp dx, [eax+0x8] */
            ii(0x1008_f98b, 2); if(jz(0x1008_f98f, 2)) goto l_0x1008_f98f; /* jz 0x1008f98f */
        l_0x1008_f98d:
            ii(0x1008_f98d, 2); jmp(0x1008_f998, 9); goto l_0x1008_f998; /* jmp 0x1008f998 */
        l_0x1008_f98f:
            ii(0x1008_f98f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_f992, 4); cmp(memb[ds, eax + 37], 9);             /* cmp byte [eax+0x25], 0x9 */
            ii(0x1008_f996, 2); if(jl(0x1008_f9a1, 9)) goto l_0x1008_f9a1; /* jl 0x1008f9a1 */
        l_0x1008_f998:
            ii(0x1008_f998, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_f99c, 5); jmp(0x1008_fa30, 0x8f); goto l_0x1008_fa30; /* jmp 0x1008fa30 */
        l_0x1008_f9a1:
            ii(0x1008_f9a1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_f9a4, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_f9a7, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1008_f9aa, 5); call(0x1007_5e64, -0x1_9b4b);           /* call 0x10075e64 */
            ii(0x1008_f9af, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f9b1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_f9b4, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_f9b7, 5); call(0x1007_65d0, -0x1_93ec);           /* call 0x100765d0 */
            ii(0x1008_f9bc, 5); call(0x1007_0ca1, -0x1_ed20);           /* call 0x10070ca1 */
            ii(0x1008_f9c1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_f9c3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_f9c6, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x1008_f9c9, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1008_f9cc, 5); call(0x1007_5e64, -0x1_9b6d);           /* call 0x10075e64 */
            ii(0x1008_f9d1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f9d3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_f9d6, 5); call(0x1007_0ca1, -0x1_ed3a);           /* call 0x10070ca1 */
            ii(0x1008_f9db, 3); cmp(bx, ax);                            /* cmp bx, ax */
            ii(0x1008_f9de, 2); if(jg(0x1008_f9e6, 6)) goto l_0x1008_f9e6; /* jg 0x1008f9e6 */
            ii(0x1008_f9e0, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_f9e4, 2); jmp(0x1008_fa30, 0x4a); goto l_0x1008_fa30; /* jmp 0x1008fa30 */
        l_0x1008_f9e6:
            ii(0x1008_f9e6, 5); call(0x1008_a79c, -0x524f);             /* call 0x1008a79c */
            ii(0x1008_f9eb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_f9ed, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_f9ef, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_f9f2, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_f9f5, 5); call(0x1007_65d0, -0x1_942a);           /* call 0x100765d0 */
            ii(0x1008_f9fa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_f9fc, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_fa01, 5); call(0x100a_53ac, 0x1_59a6);            /* call 0x100a53ac */
            ii(0x1008_fa06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_fa08, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_fa0b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_fa0e, 5); call(0x1013_ad11, 0xa_b2fe);            /* call 0x1013ad11 */
            ii(0x1008_fa13, 2); test(al, al);                           /* test al, al */
            ii(0x1008_fa15, 2); if(jz(0x1008_fa2c, 0x15)) goto l_0x1008_fa2c; /* jz 0x1008fa2c */
            ii(0x1008_fa17, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_fa1a, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1008_fa1d, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_fa20, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1008_fa23, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_fa26, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_fa29, 3); call_abs(memd[ds, ebx + 44]);           /* call dword [ebx+0x2c] */
        l_0x1008_fa2c:
            ii(0x1008_fa2c, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
        l_0x1008_fa30:
            ii(0x1008_fa30, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1008_fa33, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_fa35, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_fa36, 1); pop(edi);                               /* pop edi */
            ii(0x1008_fa37, 1); pop(esi);                               /* pop esi */
            ii(0x1008_fa38, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_fa39, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_fa3a, 1); ret();                                  /* ret */
        }
    }
}
