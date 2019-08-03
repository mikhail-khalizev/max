using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8cf6afed-3d29-4ebc-a3f3-3a60fe7dd420")]
        public void Method_1011_6695()
        {
            ii(0x1011_6695, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1011_669a, 5); calld(Definitions.sys_check_available_stack_size, 0x4f6b3); /* call 0x10165d52 */
            ii(0x1011_669f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_66a0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_66a1, 1); pushd(edx);                             /* push edx */
            ii(0x1011_66a2, 1); pushd(esi);                             /* push esi */
            ii(0x1011_66a3, 1); pushd(edi);                             /* push edi */
            ii(0x1011_66a4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_66a5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_66a7, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_66ad, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_66b0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_66b3, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1011_66b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_66b9, 3); mov(eax, memd_a32[ds, eax + 0x41]);     /* mov eax, [eax+0x41] */
            ii(0x1011_66bc, 5); calld(0x100d_7f6c, -0x3e755);           /* call 0x100d7f6c */
            ii(0x1011_66c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_66c4, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x1011_66c7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_66ca, 3); imul(edx, edx, 0xe);                    /* imul edx, edx, 0xe */
            ii(0x1011_66cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_66d0, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1011_66d3, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1011_66d6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_66d8, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_66db, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x1011_66e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_66e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_66e6, 4); mov(ax, memw_a32[ds, eax + 0x49]);      /* mov ax, [eax+0x49] */
            ii(0x1011_66ea, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1011_66ed, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_66f0, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_66f4, 5); cmp(eax, 0xaf);                         /* cmp eax, 0xaf */
            ii(0x1011_66f9, 2); if(jged(0x1011_6720, 0x25)) goto l_0x1011_6720; /* jge 0x10116720 */
            ii(0x1011_66fb, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1011_66ff, 5); mov(eax, 0xaf);                         /* mov eax, 0xaf */
            ii(0x1011_6704, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_6706, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_6708, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_670a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_670d, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_670f, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_6711, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_6714, 3); mov(edx, memd_a32[ds, edx + 0x25]);     /* mov edx, [edx+0x25] */
            ii(0x1011_6717, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_671a, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1011_671d, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x1011_6720:
            ii(0x1011_6720, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6723, 4); mov(ax, memw_a32[ds, eax + 0x4d]);      /* mov ax, [eax+0x4d] */
            ii(0x1011_6727, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_672a, 4); add(ax, memw_a32[ds, edx + 0x4b]);      /* add ax, [edx+0x4b] */
            ii(0x1011_672e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_6731, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_6734, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_6737, 4); cmp(ax, memw_a32[ds, edx + 0x49]);      /* cmp ax, [edx+0x49] */
            ii(0x1011_673b, 2); if(jled(0x1011_6747, 0xa)) goto l_0x1011_6747; /* jle 0x10116747 */
            ii(0x1011_673d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6740, 4); mov(ax, memw_a32[ds, eax + 0x49]);      /* mov ax, [eax+0x49] */
            ii(0x1011_6744, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1011_6747:
            ii(0x1011_6747, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_674e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6751, 4); mov(ax, memw_a32[ds, eax + 0x4d]);      /* mov ax, [eax+0x4d] */
            ii(0x1011_6755, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_6758, 2); jmpd(0x1011_6760, 0x6); goto l_0x1011_6760; /* jmp 0x10116760 */
        l_0x1011_675a:
            ii(0x1011_675a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_675d, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1011_6760:
            ii(0x1011_6760, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_6763, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1011_6767, 6); if(jged(0x1011_6823, 0xb6)) goto l_0x1011_6823; /* jge 0x10116823 */
            ii(0x1011_676d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6770, 4); cmp(memb_a32[ds, eax + 0x40], 0);       /* cmp byte [eax+0x40], 0x0 */
            ii(0x1011_6774, 2); if(jzd(0x1011_67c0, 0x4a)) goto l_0x1011_67c0; /* jz 0x101167c0 */
            ii(0x1011_6776, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_677a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_677d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_677f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6782, 3); mov(eax, memd_a32[ds, eax + 0x45]);     /* mov eax, [eax+0x45] */
            ii(0x1011_6785, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_6787, 5); calld(Definitions.my_strobj_c_str_v2, -0x8cfc4); /* call 0x100897c8 */
            ii(0x1011_678c, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x1011_6792, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_6795, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_6799, 5); cmp(eax, 0x109);                        /* cmp eax, 0x109 */
            ii(0x1011_679e, 2); if(jled(0x1011_67a7, 0x7)) goto l_0x1011_67a7; /* jle 0x101167a7 */
            ii(0x1011_67a0, 7); mov(memd_a32[ss, ebp - 0xc], 0x109);    /* mov dword [ebp-0xc], 0x109 */
        l_0x1011_67a7:
            ii(0x1011_67a7, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_67ab, 5); mov(eax, 0x109);                        /* mov eax, 0x109 */
            ii(0x1011_67b0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_67b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_67b4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_67b6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_67b9, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_67bb, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_67bd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1011_67c0:
            ii(0x1011_67c0, 5); pushd(0x1_00ff);                        /* push 0x100ff */
            ii(0x1011_67c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_67c8, 3); mov(ecx, memd_a32[ds, eax + 0x25]);     /* mov ecx, [eax+0x25] */
            ii(0x1011_67cb, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1011_67ce, 5); mov(ebx, 0x109);                        /* mov ebx, 0x109 */
            ii(0x1011_67d3, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1011_67d7, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_67da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_67dd, 3); mov(eax, memd_a32[ds, eax + 0x45]);     /* mov eax, [eax+0x45] */
            ii(0x1011_67e0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_67e2, 5); calld(Definitions.my_strobj_c_str_v2, -0x8d01f); /* call 0x100897c8 */
            ii(0x1011_67e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_67e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_67ec, 3); mov(esi, memd_a32[ds, eax + 0x4b]);     /* mov esi, [eax+0x4b] */
            ii(0x1011_67ef, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1011_67f2, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_67f6, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1011_67f8, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1011_67fa, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x1011_6800, 3); imul(esi, eax);                         /* imul esi, eax */
            ii(0x1011_6803, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6806, 3); mov(eax, memd_a32[ds, eax + 0x25]);     /* mov eax, [eax+0x25] */
            ii(0x1011_6809, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_680c, 3); imul(esi, eax);                         /* imul esi, eax */
            ii(0x1011_680f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_6813, 3); add(eax, memd_a32[ss, ebp - 0x18]);     /* add eax, [ebp-0x18] */
            ii(0x1011_6816, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1011_6818, 6); calld_abs(memd_a32[ds, 0x101b_ddec]);   /* call dword [0x101bddec] */
            ii(0x1011_681e, 5); jmpd(0x1011_675a, -0xc9); goto l_0x1011_675a; /* jmp 0x1011675a */
        l_0x1011_6823:
            ii(0x1011_6823, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_6826, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1011_6829, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_682c, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1011_682f, 5); calld(Definitions.sys_display_draw_1, 0x50c74); /* call 0x101674a8 */
            ii(0x1011_6834, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_6836, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_6837, 1); popd(edi);                              /* pop edi */
            ii(0x1011_6838, 1); popd(esi);                              /* pop esi */
            ii(0x1011_6839, 1); popd(edx);                              /* pop edx */
            ii(0x1011_683a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_683b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_683c, 1); retd(); return;                         /* ret */
        }
    }
}
