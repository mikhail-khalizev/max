using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2912-c49527d5")]
        public void Method_1010_2912()
        {
            ii(0x1010_2912, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_2917, 5); calld(Definitions.sys_check_available_stack_size, 0x6_3436); /* call 0x10165d52 */
            ii(0x1010_291c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_291d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_291e, 1); pushd(edx);                             /* push edx */
            ii(0x1010_291f, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2920, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2921, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2922, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2924, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_292a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_292c, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1010_2931, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_2933, 6); if(jzd(0x1010_29f0, 0xb7)) goto l_0x1010_29f0; /* jz 0x101029f0 */
            ii(0x1010_2939, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1010_293e, 5); calld(0x1007_5fdc, -0x8_c967);          /* call 0x10075fdc */
            ii(0x1010_2943, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_2946, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_294a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_294e, 3); cmp(eax, 0xf);                          /* cmp eax, 0xf */
            ii(0x1010_2951, 2); if(jged(0x1010_29a7, 0x54)) goto l_0x1010_29a7; /* jge 0x101029a7 */
            ii(0x1010_2953, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_295a, 2); jmpd(0x1010_2962, 0x6); goto l_0x1010_2962; /* jmp 0x10102962 */
        l_0x1010_295c:
            ii(0x1010_295c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_295f, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1010_2962:
            ii(0x1010_2962, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_2966, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_2969, 2); if(jged(0x1010_29a7, 0x3c)) goto l_0x1010_29a7; /* jge 0x101029a7 */
            ii(0x1010_296b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_296f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_2975, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1010_297b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_2980, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_2983, 2); if(jnzd(0x1010_2998, 0x13)) goto l_0x1010_2998; /* jnz 0x10102998 */
            ii(0x1010_2985, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_2989, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_298f, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x1010_2996, 2); if(jzd(0x1010_299a, 0x2)) goto l_0x1010_299a; /* jz 0x1010299a */
        l_0x1010_2998:
            ii(0x1010_2998, 2); jmpd(0x1010_29a5, 0xb); goto l_0x1010_29a5; /* jmp 0x101029a5 */
        l_0x1010_299a:
            ii(0x1010_299a, 7); mov(memd_a32[ss, ebp - 0x8], 0xf);      /* mov dword [ebp-0x8], 0xf */
            ii(0x1010_29a1, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
        l_0x1010_29a5:
            ii(0x1010_29a5, 2); jmpd(0x1010_295c, -0x4b); goto l_0x1010_295c; /* jmp 0x1010295c */
        l_0x1010_29a7:
            ii(0x1010_29a7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_29ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_29ad, 2); if(jled(0x1010_29ba, 0xb)) goto l_0x1010_29ba; /* jle 0x101029ba */
            ii(0x1010_29af, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_29b1, 5); mov(al, memb_a32[ds, 0x101c_37d2]);     /* mov al, [0x101c37d2] */
            ii(0x1010_29b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_29b8, 2); if(jzd(0x1010_29bc, 0x2)) goto l_0x1010_29bc; /* jz 0x101029bc */
        l_0x1010_29ba:
            ii(0x1010_29ba, 2); jmpd(0x1010_29f0, 0x34); goto l_0x1010_29f0; /* jmp 0x101029f0 */
        l_0x1010_29bc:
            ii(0x1010_29bc, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x1010_29c1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_29c4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_29c6, 2); if(jzd(0x1010_29e2, 0x1a)) goto l_0x1010_29e2; /* jz 0x101029e2 */
            ii(0x1010_29c8, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_29cc, 2); if(jnzd(0x1010_29e2, 0x14)) goto l_0x1010_29e2; /* jnz 0x101029e2 */
            ii(0x1010_29ce, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_29d2, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x1010_29d7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_29da, 5); calld(Definitions.my_min, -0x7_925b);   /* call 0x10089784 */
            ii(0x1010_29df, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1010_29e2:
            ii(0x1010_29e2, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_29e6, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_29eb, 5); calld(0x100f_b4fd, -0x74f3);            /* call 0x100fb4fd */
        l_0x1010_29f0:
            ii(0x1010_29f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_29f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_29f3, 1); popd(edi);                              /* pop edi */
            ii(0x1010_29f4, 1); popd(esi);                              /* pop esi */
            ii(0x1010_29f5, 1); popd(edx);                              /* pop edx */
            ii(0x1010_29f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_29f7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_29f8, 1); retd(); return;                         /* ret */
        }
    }
}
