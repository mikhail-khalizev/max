using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_c072-cfb05515")]
        public void Method_100f_c072()
        {
            ii(0x100f_c072, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_c077, 5); calld(Definitions.sys_check_available_stack_size, 0x6_9cd6); /* call 0x10165d52 */
            ii(0x100f_c07c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_c07d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_c07e, 1); pushd(edx);                             /* push edx */
            ii(0x100f_c07f, 1); pushd(esi);                             /* push esi */
            ii(0x100f_c080, 1); pushd(edi);                             /* push edi */
            ii(0x100f_c081, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_c082, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_c084, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
        l_0x100f_c08a:
            ii(0x100f_c08a, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100f_c08e, 7); mov(memd_a32[ss, ebp - 0xc], 0x4);      /* mov dword [ebp-0xc], 0x4 */
            ii(0x100f_c095, 2); jmpd(0x100f_c09d, 0x6); goto l_0x100f_c09d; /* jmp 0x100fc09d */
        l_0x100f_c097:
            ii(0x100f_c097, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_c09a, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
        l_0x100f_c09d:
            ii(0x100f_c09d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_c0a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c0a3, 6); if(jld(0x100f_c136, 0x8d)) goto l_0x100f_c136; /* jl 0x100fc136 */
            ii(0x100f_c0a9, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_c0ad, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_c0b3, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_c0b9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_c0be, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_c0c1, 2); if(jnzd(0x100f_c0e5, 0x22)) goto l_0x100f_c0e5; /* jnz 0x100fc0e5 */
            ii(0x100f_c0c3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_c0c7, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_c0ca, 7); cmp(memb_a32[ds, eax + 0x101c_35c6], 0x2); /* cmp byte [eax+0x101c35c6], 0x2 */
            ii(0x100f_c0d1, 2); if(jzd(0x100f_c0e3, 0x10)) goto l_0x100f_c0e3; /* jz 0x100fc0e3 */
            ii(0x100f_c0d3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_c0d7, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_c0da, 7); cmp(memb_a32[ds, eax + 0x101c_35c6], 0x3); /* cmp byte [eax+0x101c35c6], 0x3 */
            ii(0x100f_c0e1, 2); if(jnzd(0x100f_c0e5, 0x2)) goto l_0x100f_c0e5; /* jnz 0x100fc0e5 */
        l_0x100f_c0e3:
            ii(0x100f_c0e3, 2); jmpd(0x100f_c0e7, 0x2); goto l_0x100f_c0e7; /* jmp 0x100fc0e7 */
        l_0x100f_c0e5:
            ii(0x100f_c0e5, 2); jmpd(0x100f_c131, 0x4a); goto l_0x100f_c131; /* jmp 0x100fc131 */
        l_0x100f_c0e7:
            ii(0x100f_c0e7, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100f_c0eb, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100f_c0ee, 5); mov(memb_a32[ds, 0x101c_37da], al);     /* mov [0x101c37da], al */
            ii(0x100f_c0f3, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100f_c0f6, 5); mov(memb_a32[ds, 0x101c_37c8], al);     /* mov [0x101c37c8], al */
            ii(0x100f_c0fb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_c0fd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_c0ff, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_c104, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_c106, 5); calld(0x1010_1620, 0x5515);             /* call 0x10101620 */
            ii(0x100f_c10b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_c110, 5); calld(0x1010_0efe, 0x4de9);             /* call 0x10100efe */
            ii(0x100f_c115, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_c119, 5); calld(0x100f_bfde, -0x140);             /* call 0x100fbfde */
            ii(0x100f_c11e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_c122, 5); calld(0x100f_bbed, -0x53a);             /* call 0x100fbbed */
            ii(0x100f_c127, 2); test(al, al);                           /* test al, al */
            ii(0x100f_c129, 2); if(jnzd(0x100f_c131, 0x6)) goto l_0x100f_c131; /* jnz 0x100fc131 */
            ii(0x100f_c12b, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_c12f, 2); jmpd(0x100f_c144, 0x13); goto l_0x100f_c144; /* jmp 0x100fc144 */
        l_0x100f_c131:
            ii(0x100f_c131, 5); jmpd(0x100f_c097, -0x9f); goto l_0x100f_c097; /* jmp 0x100fc097 */
        l_0x100f_c136:
            ii(0x100f_c136, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_c13a, 6); if(jnzd(0x100f_c08a, -0xb6)) goto l_0x100f_c08a; /* jnz 0x100fc08a */
            ii(0x100f_c140, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_c144:
            ii(0x100f_c144, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_c147, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c149, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_c14a, 1); popd(edi);                              /* pop edi */
            ii(0x100f_c14b, 1); popd(esi);                              /* pop esi */
            ii(0x100f_c14c, 1); popd(edx);                              /* pop edx */
            ii(0x100f_c14d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_c14e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_c14f, 1); retd();                                 /* ret */
        }
    }
}
