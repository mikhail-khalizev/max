using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b1767a9d-78aa-4a04-9267-317facc20f63")]
        public void Method_100f_c150()
        {
            ii(0x100f_c150, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_c155, 5); calld(Definitions.sys_check_available_stack_size, 0x69bf8); /* call 0x10165d52 */
            ii(0x100f_c15a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_c15b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_c15c, 1); pushd(edx);                             /* push edx */
            ii(0x100f_c15d, 1); pushd(esi);                             /* push esi */
            ii(0x100f_c15e, 1); pushd(edi);                             /* push edi */
            ii(0x100f_c15f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_c160, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_c162, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_c168, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_c16b, 7); mov(memb_a32[ds, 0x101c_391e], 0x7);    /* mov byte [0x101c391e], 0x7 */
            ii(0x100f_c172, 5); calld(/* sys */ 0x1016_bcc4, 0x6fb4d);  /* call 0x1016bcc4 */
            ii(0x100f_c177, 7); mov(memb_a32[ds, 0x101c_388f], 0x1);    /* mov byte [0x101c388f], 0x1 */
            ii(0x100f_c17e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_c181, 5); mov(memb_a32[ds, 0x101c_37da], al);     /* mov [0x101c37da], al */
            ii(0x100f_c186, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_c189, 5); mov(memb_a32[ds, 0x101c_37c8], al);     /* mov [0x101c37c8], al */
            ii(0x100f_c18e, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_c192, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100f_c198, 6); mov(dl, memb_a32[ds, edx + 0x101c_a4ef]); /* mov dl, [edx+0x101ca4ef] */
            ii(0x100f_c19e, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x100f_c1a4, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x100f_c1a9, 5); calld(0x100c_aafc, -0x316b2);           /* call 0x100caafc */
            ii(0x100f_c1ae, 7); cmp(memd_a32[ds, 0x101c_9450], 0);      /* cmp dword [0x101c9450], 0x0 */
            ii(0x100f_c1b5, 2); if(jzd(0x100f_c1d1, 0x1a)) goto l_0x100f_c1d1; /* jz 0x100fc1d1 */
            ii(0x100f_c1b7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_c1b9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_c1bb, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_c1c0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_c1c2, 5); calld(0x1010_1620, 0x5459);             /* call 0x10101620 */
            ii(0x100f_c1c7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_c1cc, 5); calld(0x1010_0efe, 0x4d2d);             /* call 0x10100efe */
        l_0x100f_c1d1:
            ii(0x100f_c1d1, 7); mov(memb_a32[ds, 0x101c_391e], 0x7);    /* mov byte [0x101c391e], 0x7 */
            ii(0x100f_c1d8, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c1dc, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_c1e2, 6); mov(al, memb_a32[ds, eax + 0x101c_a4ef]); /* mov al, [eax+0x101ca4ef] */
            ii(0x100f_c1e8, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_c1ea, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_c1ed, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x100f_c1f2, 5); calld(0x1010_6752, 0xa55b);             /* call 0x10106752 */
            ii(0x100f_c1f7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_c1f9, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x100f_c1fe, 5); calld(0x1007_5fdc, -0x86227);           /* call 0x10075fdc */
            ii(0x100f_c203, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_c205, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c208, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_c20c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c20e, 2); if(jnzd(0x100f_c21b, 0xb)) goto l_0x100f_c21b; /* jnz 0x100fc21b */
            ii(0x100f_c210, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c214, 5); calld(0x100d_c4fb, -0x1fd1e);           /* call 0x100dc4fb */
            ii(0x100f_c219, 2); jmpd(0x100f_c234, 0x19); goto l_0x100f_c234; /* jmp 0x100fc234 */
        l_0x100f_c21b:
            ii(0x100f_c21b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c21f, 5); calld(0x100f_b43c, -0xde8);             /* call 0x100fb43c */
            ii(0x100f_c224, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c226, 2); if(jnzd(0x100f_c234, 0xc)) goto l_0x100f_c234; /* jnz 0x100fc234 */
            ii(0x100f_c228, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_c22f, 5); jmpd(0x100f_c2b1, 0x7d); goto l_0x100f_c2b1; /* jmp 0x100fc2b1 */
        l_0x100f_c234:
            ii(0x100f_c234, 7); cmp(memd_a32[ds, 0x101c_9450], 0);      /* cmp dword [0x101c9450], 0x0 */
            ii(0x100f_c23b, 2); if(jnzd(0x100f_c242, 0x5)) goto l_0x100f_c242; /* jnz 0x100fc242 */
            ii(0x100f_c23d, 5); calld(0x100f_b82b, -0xa17);             /* call 0x100fb82b */
        l_0x100f_c242:
            ii(0x100f_c242, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_c246, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c248, 2); if(jnzd(0x100f_c253, 0x9)) goto l_0x100f_c253; /* jnz 0x100fc253 */
            ii(0x100f_c24a, 7); cmp(memb_a32[ds, 0x101c_388b], 0);      /* cmp byte [0x101c388b], 0x0 */
            ii(0x100f_c251, 2); if(jnzd(0x100f_c255, 0x2)) goto l_0x100f_c255; /* jnz 0x100fc255 */
        l_0x100f_c253:
            ii(0x100f_c253, 2); jmpd(0x100f_c25e, 0x9); goto l_0x100f_c25e; /* jmp 0x100fc25e */
        l_0x100f_c255:
            ii(0x100f_c255, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c259, 5); calld(0x100f_bfde, -0x280);             /* call 0x100fbfde */
        l_0x100f_c25e:
            ii(0x100f_c25e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c262, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_c265, 7); mov(memb_a32[ds, eax + 0x101c_35c6], 0x1); /* mov byte [eax+0x101c35c6], 0x1 */
            ii(0x100f_c26c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_c270, 5); calld(0x100f_bbed, -0x688);             /* call 0x100fbbed */
            ii(0x100f_c275, 2); test(al, al);                           /* test al, al */
            ii(0x100f_c277, 2); if(jnzd(0x100f_c2a3, 0x2a)) goto l_0x100f_c2a3; /* jnz 0x100fc2a3 */
            ii(0x100f_c279, 7); cmp(memb_a32[ds, 0x101c_391e], 0x3);    /* cmp byte [0x101c391e], 0x3 */
            ii(0x100f_c280, 2); if(jzd(0x100f_c28b, 0x9)) goto l_0x100f_c28b; /* jz 0x100fc28b */
            ii(0x100f_c282, 7); cmp(memb_a32[ds, 0x101c_391e], 0xf);    /* cmp byte [0x101c391e], 0xf */
            ii(0x100f_c289, 2); if(jnzd(0x100f_c28d, 0x2)) goto l_0x100f_c28d; /* jnz 0x100fc28d */
        l_0x100f_c28b:
            ii(0x100f_c28b, 2); jmpd(0x100f_c295, 0x8); goto l_0x100f_c295; /* jmp 0x100fc295 */
        l_0x100f_c28d:
            ii(0x100f_c28d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_c291, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_c293, 2); if(jnzd(0x100f_c29e, 0x9)) goto l_0x100f_c29e; /* jnz 0x100fc29e */
        l_0x100f_c295:
            ii(0x100f_c295, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_c29c, 2); jmpd(0x100f_c2b1, 0x13); goto l_0x100f_c2b1; /* jmp 0x100fc2b1 */
        l_0x100f_c29e:
            ii(0x100f_c29e, 5); jmpd(0x100f_c1d1, -0xd2); goto l_0x100f_c1d1; /* jmp 0x100fc1d1 */
        l_0x100f_c2a3:
            ii(0x100f_c2a3, 7); mov(memb_a32[ds, 0x101c_391d], 0);      /* mov byte [0x101c391d], 0x0 */
            ii(0x100f_c2aa, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x100f_c2b1:
            ii(0x100f_c2b1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_c2b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c2b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_c2b7, 1); popd(edi);                              /* pop edi */
            ii(0x100f_c2b8, 1); popd(esi);                              /* pop esi */
            ii(0x100f_c2b9, 1); popd(edx);                              /* pop edx */
            ii(0x100f_c2ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_c2bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_c2bc, 1); retd(); return;                         /* ret */
        }
    }
}
