using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_2955-b22581de")]
        public void Method_100f_2955()
        {
            ii(0x100f_2955, 5); push(0x38);                             /* push 0x38 */
            ii(0x100f_295a, 5); call(Definitions.sys_check_available_stack_size, 0x7_33f3); /* call 0x10165d52 */
            ii(0x100f_295f, 1); push(ebx);                              /* push ebx */
            ii(0x100f_2960, 1); push(ecx);                              /* push ecx */
            ii(0x100f_2961, 1); push(edx);                              /* push edx */
            ii(0x100f_2962, 1); push(esi);                              /* push esi */
            ii(0x100f_2963, 1); push(edi);                              /* push edi */
            ii(0x100f_2964, 1); push(ebp);                              /* push ebp */
            ii(0x100f_2965, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_2967, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100f_296d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_296f, 5); mov(al, memb[ds, 0x101c_3919]);         /* mov al, [0x101c3919] */
            ii(0x100f_2974, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_2976, 6); if(jz(0x100f_2a66, 0xea)) goto l_0x100f_2a66; /* jz 0x100f2a66 */
            ii(0x100f_297c, 5); mov(eax, memd[ds, 0x101c_393c]);        /* mov eax, [0x101c393c] */
            ii(0x100f_2981, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_2984, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_2988, 2); if(jz(0x100f_299e, 0x14)) goto l_0x100f_299e; /* jz 0x100f299e */
            ii(0x100f_298a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_298c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_298f, 5); call(Definitions.my_dtor_d2, -0x2_445c); /* call 0x100ce538 */
            ii(0x100f_2994, 5); call(Definitions.sys_delete, 0x7_35cb); /* call 0x10165f64 */
            ii(0x100f_2999, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100f_299c, 2); jmp(0x100f_29a5, 7); goto l_0x100f_29a5; /* jmp 0x100f29a5 */
        l_0x100f_299e:
            ii(0x100f_299e, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x100f_29a5:
            ii(0x100f_29a5, 10); mov(memd[ds, 0x101c_393c], 0);         /* mov dword [0x101c393c], 0x0 */
            ii(0x100f_29af, 5); call(0x100f_0fc5, -0x19ef);             /* call 0x100f0fc5 */
            ii(0x100f_29b4, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_29bb, 2); jmp(0x100f_29c3, 6); goto l_0x100f_29c3; /* jmp 0x100f29c3 */
        l_0x100f_29bd:
            ii(0x100f_29bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_29c0, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
        l_0x100f_29c3:
            ii(0x100f_29c3, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_29c7, 3); cmp(eax, 6);                            /* cmp eax, 0x6 */
            ii(0x100f_29ca, 6); if(jae(0x100f_2a58, 0x88)) goto l_0x100f_2a58; /* jae 0x100f2a58 */
            ii(0x100f_29d0, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_29d4, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_29d7, 6); mov(eax, memd[ds, eax + 0x101b_891a]);  /* mov eax, [eax+0x101b891a] */
            ii(0x100f_29dd, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100f_29e0, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_29e4, 2); if(jz(0x100f_29fa, 0x14)) goto l_0x100f_29fa; /* jz 0x100f29fa */
            ii(0x100f_29e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_29e8, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100f_29eb, 5); call(Definitions.my_dtor_d3, -0x1_acbd); /* call 0x100d7d33 */
            ii(0x100f_29f0, 5); call(Definitions.sys_delete, 0x7_356f); /* call 0x10165f64 */
            ii(0x100f_29f5, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_29f8, 2); jmp(0x100f_2a01, 7); goto l_0x100f_2a01; /* jmp 0x100f2a01 */
        l_0x100f_29fa:
            ii(0x100f_29fa, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
        l_0x100f_2a01:
            ii(0x100f_2a01, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2a05, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_2a08, 7); cmp(memd[ds, eax + 0x101b_8913], 0);    /* cmp dword [eax+0x101b8913], 0x0 */
            ii(0x100f_2a0f, 2); if(jz(0x100f_2a53, 0x42)) goto l_0x100f_2a53; /* jz 0x100f2a53 */
            ii(0x100f_2a11, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2a15, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_2a18, 6); mov(eax, memd[ds, eax + 0x101b_8913]);  /* mov eax, [eax+0x101b8913] */
            ii(0x100f_2a1e, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100f_2a21, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_2a25, 2); if(jz(0x100f_2a3b, 0x14)) goto l_0x100f_2a3b; /* jz 0x100f2a3b */
            ii(0x100f_2a27, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2a29, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_2a2c, 5); call(Definitions.my_dtor_d2, -0x2_44f9); /* call 0x100ce538 */
            ii(0x100f_2a31, 5); call(Definitions.sys_delete, 0x7_352e); /* call 0x10165f64 */
            ii(0x100f_2a36, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100f_2a39, 2); jmp(0x100f_2a42, 7); goto l_0x100f_2a42; /* jmp 0x100f2a42 */
        l_0x100f_2a3b:
            ii(0x100f_2a3b, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
        l_0x100f_2a42:
            ii(0x100f_2a42, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2a46, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_2a49, 10); mov(memd[ds, eax + 0x101b_8913], 0);   /* mov dword [eax+0x101b8913], 0x0 */
        l_0x100f_2a53:
            ii(0x100f_2a53, 5); jmp(0x100f_29bd, -0x9b); goto l_0x100f_29bd; /* jmp 0x100f29bd */
        l_0x100f_2a58:
            ii(0x100f_2a58, 7); mov(memb[ds, 0x101c_3919], 0);          /* mov byte [0x101c3919], 0x0 */
            ii(0x100f_2a5f, 7); mov(memb[ds, 0x101c_3916], 0);          /* mov byte [0x101c3916], 0x0 */
        l_0x100f_2a66:
            ii(0x100f_2a66, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_2a68, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_2a69, 1); pop(edi);                               /* pop edi */
            ii(0x100f_2a6a, 1); pop(esi);                               /* pop esi */
            ii(0x100f_2a6b, 1); pop(edx);                               /* pop edx */
            ii(0x100f_2a6c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_2a6d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_2a6e, 1); ret();                                  /* ret */
        }
    }
}
