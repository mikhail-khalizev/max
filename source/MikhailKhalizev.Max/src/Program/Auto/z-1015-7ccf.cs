using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_7ccf-a9671507")]
        public void Method_1015_7ccf()
        {
            ii(0x1015_7ccf, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1015_7cd4, 5); calld(Definitions.sys_check_available_stack_size, 0xe079); /* call 0x10165d52 */
            ii(0x1015_7cd9, 1); pushd(esi);                             /* push esi */
            ii(0x1015_7cda, 1); pushd(edi);                             /* push edi */
            ii(0x1015_7cdb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_7cdc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_7cde, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_7ce4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_7ce7, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x1015_7cea, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1015_7ced, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1015_7cf0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7cf2, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7cf5, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1015_7cf7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_7cfa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_7cfd, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1015_7cff, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_7d04, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1015_7d07, 2); if(jged(0x1015_7d12, 0x9)) goto l_0x1015_7d12; /* jge 0x10157d12 */
            ii(0x1015_7d09, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1015_7d10, 2); jmpd(0x1015_7d2b, 0x19); goto l_0x1015_7d2b; /* jmp 0x10157d2b */
        l_0x1015_7d12:
            ii(0x1015_7d12, 5); mov(ecx, 0x67b);                        /* mov ecx, 0x67b */
            ii(0x1015_7d17, 5); mov(ebx, StringDefinitions.UnitsmgrCpp6); /* mov ebx, 0x101b2400 */
            ii(0x1015_7d1c, 5); mov(edx, StringDefinitions.ButtonsPopupCountLessMaxpopupbuttons); /* mov edx, 0x101b240d */
            ii(0x1015_7d21, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7d23, 5); calld(Definitions.sys_assert, 0xe06a);  /* call 0x10165d92 */
            ii(0x1015_7d28, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1015_7d2b:
            ii(0x1015_7d2b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_7d2d, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1015_7d30, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_7d33, 4); cmp(memb_a32[ss, ebp - 0x4], 0x30);     /* cmp byte [ebp-0x4], 0x30 */
            ii(0x1015_7d37, 2); if(jnzd(0x1015_7d40, 0x7)) goto l_0x1015_7d40; /* jnz 0x10157d40 */
            ii(0x1015_7d39, 7); mov(memd_a32[ss, ebp - 0x1c], 0x3a);    /* mov dword [ebp-0x1c], 0x3a */
        l_0x1015_7d40:
            ii(0x1015_7d40, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_7d44, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_7d46, 2); if(jled(0x1015_7d5c, 0x14)) goto l_0x1015_7d5c; /* jle 0x10157d5c */
            ii(0x1015_7d48, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_7d4c, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_7d4f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_7d51, 3); mov(dl, memb_a32[ds, eax + 0xa]);       /* mov dl, [eax+0xa] */
            ii(0x1015_7d54, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1015_7d58, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_7d5a, 2); if(jgd(0x1015_7d5e, 0x2)) goto l_0x1015_7d5e; /* jg 0x10157d5e */
        l_0x1015_7d5c:
            ii(0x1015_7d5c, 2); jmpd(0x1015_7d66, 0x8); goto l_0x1015_7d66; /* jmp 0x10157d66 */
        l_0x1015_7d5e:
            ii(0x1015_7d5e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_7d61, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
            ii(0x1015_7d64, 2); jmpd(0x1015_7d40, -0x26); goto l_0x1015_7d40; /* jmp 0x10157d40 */
        l_0x1015_7d66:
            ii(0x1015_7d66, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_7d69, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1015_7d6b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_7d6d, 1); dec(eax);                               /* dec eax */
            ii(0x1015_7d6e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_7d71, 2); jmpd(0x1015_7d79, 0x6); goto l_0x1015_7d79; /* jmp 0x10157d79 */
        l_0x1015_7d73:
            ii(0x1015_7d73, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_7d76, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
        l_0x1015_7d79:
            ii(0x1015_7d79, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_7d7c, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1015_7d80, 2); if(jld(0x1015_7df7, 0x75)) goto l_0x1015_7df7; /* jl 0x10157df7 */
            ii(0x1015_7d82, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_7d86, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_7d89, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_7d8c, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_7d90, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_7d93, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7d96, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1015_7d99, 3); mov(memd_a32[ds, edx + 0x19], eax);     /* mov [edx+0x19], eax */
            ii(0x1015_7d9c, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_7da0, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7da3, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_7da7, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_7daa, 3); mov(dl, memb_a32[ds, edx + 0x3d]);      /* mov dl, [edx+0x3d] */
            ii(0x1015_7dad, 3); mov(memb_a32[ds, eax + 0x3e], dl);      /* mov [eax+0x3e], dl */
            ii(0x1015_7db0, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_7db4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_7db7, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_7dba, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_7dbe, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_7dc1, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7dc4, 3); mov(eax, memd_a32[ds, eax + 0x47]);     /* mov eax, [eax+0x47] */
            ii(0x1015_7dc7, 3); mov(memd_a32[ds, edx + 0x4b], eax);     /* mov [edx+0x4b], eax */
            ii(0x1015_7dca, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_7dce, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7dd1, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_7dd5, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_7dd8, 3); mov(dl, memb_a32[ds, edx + 0x1]);       /* mov dl, [edx+0x1] */
            ii(0x1015_7ddb, 3); mov(memb_a32[ds, eax + 0x2], dl);       /* mov [eax+0x2], dl */
            ii(0x1015_7dde, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1015_7de2, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_7de5, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1015_7de9, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7dec, 3); mov(al, memb_a32[ds, eax + 0xb]);       /* mov al, [eax+0xb] */
            ii(0x1015_7def, 3); mov(memb_a32[ds, edx + 0xc], al);       /* mov [edx+0xc], al */
            ii(0x1015_7df2, 5); jmpd(0x1015_7d73, -0x84); goto l_0x1015_7d73; /* jmp 0x10157d73 */
        l_0x1015_7df7:
            ii(0x1015_7df7, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1015_7dfb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_7dfe, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_7e01, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_7e03, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_7e06, 3); mov(memd_a32[ds, edx + 0x15], eax);     /* mov [edx+0x15], eax */
            ii(0x1015_7e09, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_7e0d, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7e10, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_7e13, 3); mov(memb_a32[ds, edx + 0x3d], al);      /* mov [edx+0x3d], al */
            ii(0x1015_7e16, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_7e1a, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_7e1d, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7e20, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1015_7e23, 3); mov(memd_a32[ds, edx + 0x47], eax);     /* mov [edx+0x47], eax */
            ii(0x1015_7e26, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_7e2a, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7e2d, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1015_7e30, 3); mov(memb_a32[ds, edx + 0x1], al);       /* mov [edx+0x1], al */
            ii(0x1015_7e33, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_7e37, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1015_7e3a, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x1015_7e3d, 3); mov(memb_a32[ds, edx + 0xb], al);       /* mov [edx+0xb], al */
            ii(0x1015_7e40, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_7e43, 2); inc(memb_a32[ds, eax]);                 /* inc byte [eax] */
            ii(0x1015_7e45, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7e47, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_7e48, 1); popd(edi);                              /* pop edi */
            ii(0x1015_7e49, 1); popd(esi);                              /* pop esi */
            ii(0x1015_7e4a, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
