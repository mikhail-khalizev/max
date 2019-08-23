using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0ce3-7853c08f")]
        public void Method_100d_0ce3()
        {
            ii(0x100d_0ce3, 5); push(0x58);                             /* push 0x58 */
            ii(0x100d_0ce8, 5); call(Definitions.sys_check_available_stack_size, 0x9_5065); /* call 0x10165d52 */
            ii(0x100d_0ced, 1); push(ebx);                              /* push ebx */
            ii(0x100d_0cee, 1); push(ecx);                              /* push ecx */
            ii(0x100d_0cef, 1); push(edx);                              /* push edx */
            ii(0x100d_0cf0, 1); push(esi);                              /* push esi */
            ii(0x100d_0cf1, 1); push(edi);                              /* push edi */
            ii(0x100d_0cf2, 1); push(ebp);                              /* push ebp */
            ii(0x100d_0cf3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_0cf5, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100d_0cfb, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_0cfe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d01, 5); call(0x100d_0803, -0x503);              /* call 0x100d0803 */
            ii(0x100d_0d06, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d09, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100d_0d0c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0d0f, 1); push(eax);                              /* push eax */
            ii(0x100d_0d10, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d13, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_0d16, 3); add(eax, 0x73);                         /* add eax, 0x73 */
            ii(0x100d_0d19, 1); push(eax);                              /* push eax */
            ii(0x100d_0d1a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d1d, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100d_0d20, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100d_0d23, 1); push(eax);                              /* push eax */
            ii(0x100d_0d24, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d27, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100d_0d2a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_0d2c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0d2f, 1); push(eax);                              /* push eax */
            ii(0x100d_0d30, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d33, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100d_0d36, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100d_0d39, 1); push(eax);                              /* push eax */
            ii(0x100d_0d3a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d3d, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100d_0d40, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100d_0d43, 1); push(eax);                              /* push eax */
            ii(0x100d_0d44, 5); call(/* sys */ 0x1016_abbc, 0x9_9e73);  /* call 0x1016abbc */
            ii(0x100d_0d49, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100d_0d4c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_0d51, 5); call(/* sys */ 0x1016_a24c, 0x9_94f6);  /* call 0x1016a24c */
            ii(0x100d_0d56, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_0d5b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d5e, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100d_0d61, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_0d64, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0d67, 5); call(0x1007_1e00, -0x5_ef6c);           /* call 0x10071e00 */
            ii(0x100d_0d6c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_0d6f, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100d_0d76, 2); jmp(0x100d_0d7e, 0x6); goto l_0x100d_0d7e; /* jmp 0x100d0d7e */
        l_0x100d_0d78:
            ii(0x100d_0d78, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0d7b, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x100d_0d7e:
            ii(0x100d_0d7e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0d81, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_0d84, 4); cmp(ax, memw[ds, edx + 0x28]);          /* cmp ax, [edx+0x28] */
            ii(0x100d_0d88, 2); if(jge(0x100d_0d9b, 0x11)) goto l_0x100d_0d9b; /* jge 0x100d0d9b */
            ii(0x100d_0d8a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0d8d, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0d90, 5); call(Definitions.my_2_get_count, -0x4_5a2d); /* call 0x1008b368 */
            ii(0x100d_0d95, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100d_0d99, 2); if(jg(0x100d_0da0, 0x5)) goto l_0x100d_0da0; /* jg 0x100d0da0 */
        l_0x100d_0d9b:
            ii(0x100d_0d9b, 5); jmp(0x100d_0e75, 0xd5); goto l_0x100d_0e75; /* jmp 0x100d0e75 */
        l_0x100d_0da0:
            ii(0x100d_0da0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0da3, 4); mov(ax, memw[ds, eax + 0x24]);          /* mov ax, [eax+0x24] */
            ii(0x100d_0da7, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100d_0daa, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_0dad, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0db0, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0db3, 5); call(0x1008_b228, -0x4_5b90);           /* call 0x1008b228 */
            ii(0x100d_0db8, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100d_0dbb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0dbe, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100d_0dc1, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100d_0dc4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_0dc9, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x100d_0dcf, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100d_0dd4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_0dd6, 5); call(0x100d_fd2c, 0xef51);              /* call 0x100dfd2c */
            ii(0x100d_0ddb, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x100d_0ddf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_0de2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0de5, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100d_0de8, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x100d_0dec, 2); if(jnz(0x100d_0e09, 0x1b)) goto l_0x100d_0e09; /* jnz 0x100d0e09 */
            ii(0x100d_0dee, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0df1, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100d_0df4, 3); mov(ebx, memd[ds, eax + 0x50]);         /* mov ebx, [eax+0x50] */
            ii(0x100d_0df7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_0dfa, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_0dfe, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_0e02, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_0e05, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100d_0e07, 2); if(jl(0x100d_0e12, 0x9)) goto l_0x100d_0e12; /* jl 0x100d0e12 */
        l_0x100d_0e09:
            ii(0x100d_0e09, 7); mov(memd[ss, ebp - 0x14], 0xa2);        /* mov dword [ebp-0x14], 0xa2 */
            ii(0x100d_0e10, 2); jmp(0x100d_0e19, 0x7); goto l_0x100d_0e19; /* jmp 0x100d0e19 */
        l_0x100d_0e12:
            ii(0x100d_0e12, 7); mov(memd[ss, ebp - 0x14], 0x1);         /* mov dword [ebp-0x14], 0x1 */
        l_0x100d_0e19:
            ii(0x100d_0e19, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_0e1c, 1); push(eax);                              /* push eax */
            ii(0x100d_0e1d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_0e20, 3); mov(ecx, memd[ds, edx + 0x12]);         /* mov ecx, [edx+0x12] */
            ii(0x100d_0e23, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_0e26, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100d_0e2b, 4); movsx(esi, memw[ss, ebp - 0x10]);       /* movsx esi, word [ebp-0x10] */
            ii(0x100d_0e2f, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_0e33, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x100d_0e36, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x100d_0e38, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x100d_0e3e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_0e40, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_0e42, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_0e45, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_0e47, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_0e49, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x100d_0e4c, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x100d_0e4e, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x100d_0e50, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_0e53, 3); mov(edx, memd[ds, edx + 0x12]);         /* mov edx, [edx+0x12] */
            ii(0x100d_0e56, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_0e59, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_0e5c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0e5f, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_0e62, 5); add(eax, 0x87);                         /* add eax, 0x87 */
            ii(0x100d_0e67, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_0e69, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x100d_0e6b, 5); call(0x1012_b658, 0x5_a7e8);            /* call 0x1012b658 */
            ii(0x100d_0e70, 5); jmp(0x100d_0d78, -0xfd); goto l_0x100d_0d78; /* jmp 0x100d0d78 */
        l_0x100d_0e75:
            ii(0x100d_0e75, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0e78, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100d_0e7b, 3); add(eax, 0x73);                         /* add eax, 0x73 */
            ii(0x100d_0e7e, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_0e81, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0e84, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100d_0e87, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_0e8a, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_0e8d, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100d_0e90, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_0e93, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0e96, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100d_0e99, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_0e9b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0e9e, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100d_0ea1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_0ea3, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x100d_0ea6, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x100d_0ea9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_0eac, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100d_0eaf, 5); call(Definitions.sys_display_draw_1, 0x9_65f4); /* call 0x101674a8 */
            ii(0x100d_0eb4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_0eb6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_0eb7, 1); pop(edi);                               /* pop edi */
            ii(0x100d_0eb8, 1); pop(esi);                               /* pop esi */
            ii(0x100d_0eb9, 1); pop(edx);                               /* pop edx */
            ii(0x100d_0eba, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_0ebb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_0ebc, 1); ret();                                  /* ret */
        }
    }
}
