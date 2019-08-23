using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_797d-d7cd564b")]
        public void Method_1011_797d()
        {
            ii(0x1011_797d, 5); push(0x38);                             /* push 0x38 */
            ii(0x1011_7982, 5); call(Definitions.sys_check_available_stack_size, 0x4_e3cb); /* call 0x10165d52 */
            ii(0x1011_7987, 1); push(ebx);                              /* push ebx */
            ii(0x1011_7988, 1); push(ecx);                              /* push ecx */
            ii(0x1011_7989, 1); push(edx);                              /* push edx */
            ii(0x1011_798a, 1); push(esi);                              /* push esi */
            ii(0x1011_798b, 1); push(edi);                              /* push edi */
            ii(0x1011_798c, 1); push(ebp);                              /* push ebp */
            ii(0x1011_798d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_798f, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_7995, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_7998, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_799f, 2); jmp(0x1011_79a7, 0x6); goto l_0x1011_79a7; /* jmp 0x101179a7 */
        l_0x1011_79a1:
            ii(0x1011_79a1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_79a4, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1011_79a7:
            ii(0x1011_79a7, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1011_79ab, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_79ae, 6); if(jge(0x1011_7a2e, 0x7a)) goto l_0x1011_7a2e; /* jge 0x10117a2e */
            ii(0x1011_79b4, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1011_79b8, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_79bb, 5); mov(edx, 0x101c_52bc);                  /* mov edx, 0x101c52bc */
            ii(0x1011_79c0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_79c2, 5); call(0x1013_a6f4, 0x2_2d2d);            /* call 0x1013a6f4 */
            ii(0x1011_79c7, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x1011_79ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_79cd, 5); call(0x1013_bb7b, 0x2_41a9);            /* call 0x1013bb7b */
        l_0x1011_79d2:
            ii(0x1011_79d2, 3); dec(memd[ss, ebp - 0x8]);               /* dec dword [ebp-0x8] */
            ii(0x1011_79d5, 5); cmp(memw[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_79da, 2); if(jz(0x1011_7a29, 0x4d)) goto l_0x1011_7a29; /* jz 0x10117a29 */
            ii(0x1011_79dc, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1011_79e1, 5); call(Definitions.sys_new, 0x4_e41a);    /* call 0x10165e00 */
            ii(0x1011_79e6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_79e9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_79ec, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_79ef, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_79f3, 2); if(jz(0x1011_7a0b, 0x16)) goto l_0x1011_7a0b; /* jz 0x10117a0b */
            ii(0x1011_79f5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_79f8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_79fb, 5); call(0x1011_754f, -0x4b1);              /* call 0x1011754f */
            ii(0x1011_7a00, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_7a03, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_7a06, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_7a09, 2); jmp(0x1011_7a11, 0x6); goto l_0x1011_7a11; /* jmp 0x10117a11 */
        l_0x1011_7a0b:
            ii(0x1011_7a0b, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_7a0e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1011_7a11:
            ii(0x1011_7a11, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1011_7a14, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1011_7a18, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_7a1b, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_7a20, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_7a22, 5); call(0x1011_7c3c, 0x215);               /* call 0x10117c3c */
            ii(0x1011_7a27, 2); jmp(0x1011_79d2, -0x57); goto l_0x1011_79d2; /* jmp 0x101179d2 */
        l_0x1011_7a29:
            ii(0x1011_7a29, 5); jmp(0x1011_79a1, -0x8d); goto l_0x1011_79a1; /* jmp 0x101179a1 */
        l_0x1011_7a2e:
            ii(0x1011_7a2e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7a30, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_7a31, 1); pop(edi);                               /* pop edi */
            ii(0x1011_7a32, 1); pop(esi);                               /* pop esi */
            ii(0x1011_7a33, 1); pop(edx);                               /* pop edx */
            ii(0x1011_7a34, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_7a35, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_7a36, 1); ret();                                  /* ret */
        }
    }
}
