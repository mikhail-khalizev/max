using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b1cc99d8-f175-482f-89dd-4cbc7c795db8")]
        public void Method_1015_3d99()
        {
            ii(0x1015_3d99, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1015_3d9e, 5); calld(Definitions.sys_check_available_stack_size, 0x1_1faf); /* call 0x10165d52 */
            ii(0x1015_3da3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_3da4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_3da5, 1); pushd(edx);                             /* push edx */
            ii(0x1015_3da6, 1); pushd(esi);                             /* push esi */
            ii(0x1015_3da7, 1); pushd(edi);                             /* push edi */
            ii(0x1015_3da8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_3da9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_3dab, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_3db1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_3db4, 7); cmp(memb_a32[ds, 0x101c_947d], 0);      /* cmp byte [0x101c947d], 0x0 */
            ii(0x1015_3dbb, 2); if(jzd(0x1015_3dc4, 0x7)) goto l_0x1015_3dc4; /* jz 0x10153dc4 */
            ii(0x1015_3dbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3dc0, 4); mov(memb_a32[ds, eax + 0x5f], 0);       /* mov byte [eax+0x5f], 0x0 */
        l_0x1015_3dc4:
            ii(0x1015_3dc4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3dc7, 3); mov(al, memb_a32[ds, eax + 0x5e]);      /* mov al, [eax+0x5e] */
            ii(0x1015_3dca, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_3dcf, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1015_3dd2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_3dd5, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_3ddc, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_3de3, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3de7, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1015_3dea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3dec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3def, 3); mov(al, memb_a32[ds, eax + 0x5e]);      /* mov al, [eax+0x5e] */
            ii(0x1015_3df2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_3df7, 3); add(edx, 0x20);                         /* add edx, 0x20 */
            ii(0x1015_3dfa, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1015_3dfc, 2); if(jged(0x1015_3e27, 0x29)) goto l_0x1015_3e27; /* jge 0x10153e27 */
            ii(0x1015_3dfe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3e01, 4); test(memb_a32[ds, eax + 0x5e], 0x1f);   /* test byte [eax+0x5e], 0x1f */
            ii(0x1015_3e05, 2); if(jnzd(0x1015_3e25, 0x1e)) goto l_0x1015_3e25; /* jnz 0x10153e25 */
            ii(0x1015_3e07, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e0b, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d914]); /* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_3e13, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_3e16, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e1a, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d91c]); /* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_3e22, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1015_3e25:
            ii(0x1015_3e25, 2); jmpd(0x1015_3e54, 0x2d); goto l_0x1015_3e54; /* jmp 0x10153e54 */
        l_0x1015_3e27:
            ii(0x1015_3e27, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3e2a, 4); test(memb_a32[ds, eax + 0x5e], 0x1f);   /* test byte [eax+0x5e], 0x1f */
            ii(0x1015_3e2e, 2); if(jnzd(0x1015_3e54, 0x24)) goto l_0x1015_3e54; /* jnz 0x10153e54 */
            ii(0x1015_3e30, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e34, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d914]); /* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_3e3c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_3e3f, 3); neg(memd_a32[ss, ebp - 0x14]);          /* neg dword [ebp-0x14] */
            ii(0x1015_3e42, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3e46, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d91c]); /* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_3e4e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_3e51, 3); neg(memd_a32[ss, ebp - 0xc]);           /* neg dword [ebp-0xc] */
        l_0x1015_3e54:
            ii(0x1015_3e54, 5); cmp(memw_a32[ss, ebp - 0x14], 0);       /* cmp word [ebp-0x14], 0x0 */
            ii(0x1015_3e59, 2); if(jnzd(0x1015_3e62, 0x7)) goto l_0x1015_3e62; /* jnz 0x10153e62 */
            ii(0x1015_3e5b, 5); cmp(memw_a32[ss, ebp - 0xc], 0);        /* cmp word [ebp-0xc], 0x0 */
            ii(0x1015_3e60, 2); if(jzd(0x1015_3ec5, 0x63)) goto l_0x1015_3ec5; /* jz 0x10153ec5 */
        l_0x1015_3e62:
            ii(0x1015_3e62, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3e65, 4); cmp(memb_a32[ds, eax + 0x5f], 0);       /* cmp byte [eax+0x5f], 0x0 */
            ii(0x1015_3e69, 2); if(jnzd(0x1015_3e76, 0xb)) goto l_0x1015_3e76; /* jnz 0x10153e76 */
            ii(0x1015_3e6b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_3e6d, 5); mov(al, memb_a32[ds, 0x101c_947c]);     /* mov al, [0x101c947c] */
            ii(0x1015_3e72, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_3e74, 2); if(jnzd(0x1015_3e7c, 0x6)) goto l_0x1015_3e7c; /* jnz 0x10153e7c */
        l_0x1015_3e76:
            ii(0x1015_3e76, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_3e7a, 2); jmpd(0x1015_3ee9, 0x6d); goto l_0x1015_3ee9; /* jmp 0x10153ee9 */
        l_0x1015_3e7c:
            ii(0x1015_3e7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3e7f, 5); calld(0x1014_9fa8, -0x9edc);            /* call 0x10149fa8 */
            ii(0x1015_3e84, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_3e88, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_3e8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3e8f, 5); calld(0x1014_9c2f, -0xa265);            /* call 0x10149c2f */
            ii(0x1015_3e94, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_3e97, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_3e9a, 7); sub(memw_a32[ds, edx + 0xd9], ax);      /* sub [edx+0xd9], ax */
            ii(0x1015_3ea1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_3ea4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_3ea7, 7); sub(memw_a32[ds, edx + 0xdb], ax);      /* sub [edx+0xdb], ax */
            ii(0x1015_3eae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3eb1, 5); calld(0x1014_9cd1, -0xa1e5);            /* call 0x10149cd1 */
            ii(0x1015_3eb6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3eb9, 5); calld(0x1014_9fa8, -0x9f16);            /* call 0x10149fa8 */
            ii(0x1015_3ebe, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_3ec1, 4); mov(memb_a32[ds, edx + 0x5f], 0x1);     /* mov byte [edx+0x5f], 0x1 */
        l_0x1015_3ec5:
            ii(0x1015_3ec5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3ec8, 3); inc(memb_a32[ds, eax + 0x5e]);          /* inc byte [eax+0x5e] */
            ii(0x1015_3ecb, 5); cmp(memw_a32[ss, ebp - 0x14], 0);       /* cmp word [ebp-0x14], 0x0 */
            ii(0x1015_3ed0, 2); if(jnzd(0x1015_3ed9, 0x7)) goto l_0x1015_3ed9; /* jnz 0x10153ed9 */
            ii(0x1015_3ed2, 5); cmp(memw_a32[ss, ebp - 0xc], 0);        /* cmp word [ebp-0xc], 0x0 */
            ii(0x1015_3ed7, 2); if(jzd(0x1015_3edf, 0x6)) goto l_0x1015_3edf; /* jz 0x10153edf */
        l_0x1015_3ed9:
            ii(0x1015_3ed9, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1015_3edd, 2); jmpd(0x1015_3ee3, 0x4); goto l_0x1015_3ee3; /* jmp 0x10153ee3 */
        l_0x1015_3edf:
            ii(0x1015_3edf, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1015_3ee3:
            ii(0x1015_3ee3, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1015_3ee6, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1015_3ee9:
            ii(0x1015_3ee9, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_3eec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_3eee, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_3eef, 1); popd(edi);                              /* pop edi */
            ii(0x1015_3ef0, 1); popd(esi);                              /* pop esi */
            ii(0x1015_3ef1, 1); popd(edx);                              /* pop edx */
            ii(0x1015_3ef2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_3ef3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_3ef4, 1); retd(); return;                         /* ret */
        }
    }
}
