using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_634b-9d0996c2")]
        public void Method_100e_634b()
        {
            ii(0x100e_634b, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100e_6350, 5); call(Definitions.sys_check_available_stack_size, 0x7_f9fd); /* call 0x10165d52 */
            ii(0x100e_6355, 1); push(ebx);                              /* push ebx */
            ii(0x100e_6356, 1); push(ecx);                              /* push ecx */
            ii(0x100e_6357, 1); push(edx);                              /* push edx */
            ii(0x100e_6358, 1); push(esi);                              /* push esi */
            ii(0x100e_6359, 1); push(edi);                              /* push edi */
            ii(0x100e_635a, 1); push(ebp);                              /* push ebp */
            ii(0x100e_635b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_635d, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100e_6363, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_6366, 7); cmp(memd[ds, 0x101c_38c0], 8);          /* cmp dword [0x101c38c0], 0x8 */
            ii(0x100e_636d, 6); if(jl(0x100e_6492, 0x11f)) goto l_0x100e_6492; /* jl 0x100e6492 */
            ii(0x100e_6373, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_6378, 5); call(0x100e_883d, 0x24c0);              /* call 0x100e883d */
            ii(0x100e_637d, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100e_6380, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_6383, 4); test(memb[ds, eax + 18], 0x10);         /* test byte [eax+0x12], 0x10 */
            ii(0x100e_6387, 2); if(jz(0x100e_6392, 9)) goto l_0x100e_6392; /* jz 0x100e6392 */
            ii(0x100e_6389, 7); mov(memd[ss, ebp - 12], 0x40);          /* mov dword [ebp-0xc], 0x40 */
            ii(0x100e_6390, 2); jmp(0x100e_6399, 7); goto l_0x100e_6399; /* jmp 0x100e6399 */
        l_0x100e_6392:
            ii(0x100e_6392, 7); mov(memd[ss, ebp - 12], 0x20);          /* mov dword [ebp-0xc], 0x20 */
        l_0x100e_6399:
            ii(0x100e_6399, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100e_639d, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_63a0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_63a2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_63a5, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_63ab, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_63ae, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_63b1, 3); mov(edx, memd[ds, edx + 20]);           /* mov edx, [edx+0x14] */
            ii(0x100e_63b4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_63b7, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_63ba, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_63bc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_63bf, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_63c5, 6); mov(edx, memd[ds, 0x101c_38fa]);        /* mov edx, [0x101c38fa] */
            ii(0x100e_63cb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_63ce, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_63d0, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100e_63d4, 1); inc(eax);                               /* inc eax */
            ii(0x100e_63d5, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_63d7, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100e_63da, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_63dd, 3); mov(edx, memd[ds, eax + 22]);           /* mov edx, [eax+0x16] */
            ii(0x100e_63e0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_63e3, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_63e6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_63e8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_63eb, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_63f1, 6); mov(edx, memd[ds, 0x101c_38fc]);        /* mov edx, [0x101c38fc] */
            ii(0x100e_63f7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_63fa, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_63fc, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100e_6400, 1); inc(eax);                               /* inc eax */
            ii(0x100e_6401, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6403, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_6406, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_6409, 4); test(memb[ds, edx + 18], 0x10);         /* test byte [edx+0x12], 0x10 */
            ii(0x100e_640d, 2); if(jz(0x100e_6418, 9)) goto l_0x100e_6418; /* jz 0x100e6418 */
            ii(0x100e_640f, 7); mov(memd[ss, ebp - 16], 0x80);          /* mov dword [ebp-0x10], 0x80 */
            ii(0x100e_6416, 2); jmp(0x100e_641f, 7); goto l_0x100e_641f; /* jmp 0x100e641f */
        l_0x100e_6418:
            ii(0x100e_6418, 7); mov(memd[ss, ebp - 16], 0x40);          /* mov dword [ebp-0x10], 0x40 */
        l_0x100e_641f:
            ii(0x100e_641f, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100e_6423, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_6426, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6428, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_642b, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_6431, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x100e_6434, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100e_6437, 5); mov(eax, 0x1fd);                        /* mov eax, 0x1fd */
            ii(0x100e_643c, 5); call(Definitions.my_get_res_data_by_id, 0x4_db97); /* call 0x10133fd8 */
            ii(0x100e_6441, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100e_6444, 7); cmp(memd[ds, 0x101c_38c0], 0x40);       /* cmp dword [0x101c38c0], 0x40 */
            ii(0x100e_644b, 2); if(jz(0x100e_645e, 0x11)) goto l_0x100e_645e; /* jz 0x100e645e */
            ii(0x100e_644d, 6); mov(edx, memd[ds, 0x101c_38c4]);        /* mov edx, [0x101c38c4] */
            ii(0x100e_6453, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100e_6456, 5); call(0x100e_8f38, 0x2add);              /* call 0x100e8f38 */
            ii(0x100e_645b, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
        l_0x100e_645e:
            ii(0x100e_645e, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100e_6461, 1); push(eax);                              /* push eax */
            ii(0x100e_6462, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100e_6467, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_646a, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100e_646d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_6470, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_6473, 3); add(eax, memd[ss, ebp - 20]);           /* add eax, [ebp-0x14] */
            ii(0x100e_6476, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_6479, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100e_647c, 5); call(0x100e_8d1e, 0x289d);              /* call 0x100e8d1e */
            ii(0x100e_6481, 7); cmp(memd[ds, 0x101c_38c0], 0x40);       /* cmp dword [0x101c38c0], 0x40 */
            ii(0x100e_6488, 2); if(jz(0x100e_6492, 8)) goto l_0x100e_6492; /* jz 0x100e6492 */
            ii(0x100e_648a, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100e_648d, 5); call(Definitions.sys_free, 0x8_4c2f);   /* call 0x1016b0c1 */
        l_0x100e_6492:
            ii(0x100e_6492, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_6494, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_6495, 1); pop(edi);                               /* pop edi */
            ii(0x100e_6496, 1); pop(esi);                               /* pop esi */
            ii(0x100e_6497, 1); pop(edx);                               /* pop edx */
            ii(0x100e_6498, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_6499, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_649a, 1); ret();                                  /* ret */
        }
    }
}
