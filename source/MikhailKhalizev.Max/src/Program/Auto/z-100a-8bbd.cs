using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("80bd3716-a4ad-4af2-b62c-7c8730143967")]
        public void Method_100a_8bbd()
        {
            ii(0x100a_8bbd, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_8bc2, 5); calld(Definitions.sys_check_available_stack_size, 0xb_d18b); /* call 0x10165d52 */
            ii(0x100a_8bc7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_8bc8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_8bc9, 1); pushd(edx);                             /* push edx */
            ii(0x100a_8bca, 1); pushd(esi);                             /* push esi */
            ii(0x100a_8bcb, 1); pushd(edi);                             /* push edi */
            ii(0x100a_8bcc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_8bcd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_8bcf, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_8bd5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8bd7, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_8bdc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_8bde, 6); if(jzd(0x100a_8caa, 0xc6)) goto l_0x100a_8caa; /* jz 0x100a8caa */
            ii(0x100a_8be4, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100a_8beb, 2); if(jzd(0x100a_8bfa, 0xd)) goto l_0x100a_8bfa; /* jz 0x100a8bfa */
            ii(0x100a_8bed, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x100a_8bf4, 6); if(jnzd(0x100a_8ca8, 0xae)) goto l_0x100a_8ca8; /* jnz 0x100a8ca8 */
        l_0x100a_8bfa:
            ii(0x100a_8bfa, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100a_8c01, 2); jmpd(0x100a_8c09, 0x6); goto l_0x100a_8c09; /* jmp 0x100a8c09 */
        l_0x100a_8c03:
            ii(0x100a_8c03, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8c06, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100a_8c09:
            ii(0x100a_8c09, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8c0d, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_8c10, 2); if(jged(0x100a_8c61, 0x4f)) goto l_0x100a_8c61; /* jge 0x100a8c61 */
            ii(0x100a_8c12, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8c16, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_8c1c, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100a_8c23, 2); if(jnzd(0x100a_8c3f, 0x1a)) goto l_0x100a_8c3f; /* jnz 0x100a8c3f */
            ii(0x100a_8c25, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8c29, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_8c2f, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_8c35, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_8c3a, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_8c3d, 2); if(jzd(0x100a_8c41, 0x2)) goto l_0x100a_8c41; /* jz 0x100a8c41 */
        l_0x100a_8c3f:
            ii(0x100a_8c3f, 2); jmpd(0x100a_8c5f, 0x1e); goto l_0x100a_8c5f; /* jmp 0x100a8c5f */
        l_0x100a_8c41:
            ii(0x100a_8c41, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8c45, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_8c4b, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_8c50, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_8c52, 5); calld(0x100b_e436, 0x1_57df);           /* call 0x100be436 */
            ii(0x100a_8c57, 2); test(al, al);                           /* test al, al */
            ii(0x100a_8c59, 6); if(jnzd(0x100a_8d03, 0xa4)) goto l_0x100a_8d03; /* jnz 0x100a8d03 */
        l_0x100a_8c5f:
            ii(0x100a_8c5f, 2); jmpd(0x100a_8c03, -0x5e); goto l_0x100a_8c03; /* jmp 0x100a8c03 */
        l_0x100a_8c61:
            ii(0x100a_8c61, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x100a_8c68, 2); if(jnzd(0x100a_8c87, 0x1d)) goto l_0x100a_8c87; /* jnz 0x100a8c87 */
            ii(0x100a_8c6a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8c6c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100a_8c71, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_8c77, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_8c7d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_8c82, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_8c85, 2); if(jzd(0x100a_8c89, 0x2)) goto l_0x100a_8c89; /* jz 0x100a8c89 */
        l_0x100a_8c87:
            ii(0x100a_8c87, 2); jmpd(0x100a_8c9f, 0x16); goto l_0x100a_8c9f; /* jmp 0x100a8c9f */
        l_0x100a_8c89:
            ii(0x100a_8c89, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8c8b, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100a_8c90, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_8c96, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100a_8c9d, 2); if(jnzd(0x100a_8ca1, 0x2)) goto l_0x100a_8ca1; /* jnz 0x100a8ca1 */
        l_0x100a_8c9f:
            ii(0x100a_8c9f, 2); jmpd(0x100a_8ca8, 0x7); goto l_0x100a_8ca8; /* jmp 0x100a8ca8 */
        l_0x100a_8ca1:
            ii(0x100a_8ca1, 7); mov(memb_a32[ds, 0x101c_391e], 0x9);    /* mov byte [0x101c391e], 0x9 */
        l_0x100a_8ca8:
            ii(0x100a_8ca8, 2); jmpd(0x100a_8d03, 0x59); goto l_0x100a_8d03; /* jmp 0x100a8d03 */
        l_0x100a_8caa:
            ii(0x100a_8caa, 7); cmp(memb_a32[ds, 0x101c_391e], 0x8);    /* cmp byte [0x101c391e], 0x8 */
            ii(0x100a_8cb1, 2); if(jnzd(0x100a_8d03, 0x50)) goto l_0x100a_8d03; /* jnz 0x100a8d03 */
            ii(0x100a_8cb3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8cb5, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100a_8cba, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_8cc0, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_8cc6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_8ccb, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_8cce, 2); if(jnzd(0x100a_8ce6, 0x16)) goto l_0x100a_8ce6; /* jnz 0x100a8ce6 */
            ii(0x100a_8cd0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8cd2, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100a_8cd7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_8cdd, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100a_8ce4, 2); if(jzd(0x100a_8ce8, 0x2)) goto l_0x100a_8ce8; /* jz 0x100a8ce8 */
        l_0x100a_8ce6:
            ii(0x100a_8ce6, 2); jmpd(0x100a_8d03, 0x1b); goto l_0x100a_8d03; /* jmp 0x100a8d03 */
        l_0x100a_8ce8:
            ii(0x100a_8ce8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_8cea, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100a_8cef, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_8cf5, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_8cfa, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_8cfc, 5); calld(0x100b_e436, 0x1_5735);           /* call 0x100be436 */
            ii(0x100a_8d01, 2); test(al, al);                           /* test al, al */
        l_0x100a_8d03:
            ii(0x100a_8d03, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_8d05, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_8d06, 1); popd(edi);                              /* pop edi */
            ii(0x100a_8d07, 1); popd(esi);                              /* pop esi */
            ii(0x100a_8d08, 1); popd(edx);                              /* pop edx */
            ii(0x100a_8d09, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_8d0a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_8d0b, 1); retd(); return;                         /* ret */
        }
    }
}
