using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9723d440-2357-4796-ab48-4a5ab24ad318")]
        public void Method_100e_6568()
        {
            ii(0x100e_6568, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100e_656d, 5); calld(Definitions.sys_check_available_stack_size, 0x7_f7e0); /* call 0x10165d52 */
            ii(0x100e_6572, 1); pushd(esi);                             /* push esi */
            ii(0x100e_6573, 1); pushd(edi);                             /* push edi */
            ii(0x100e_6574, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_6575, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_6577, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_657d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_6580, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_6583, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_6586, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100e_6589, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_658e, 5); calld(0x100e_883d, 0x22aa);             /* call 0x100e883d */
            ii(0x100e_6593, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_6596, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_6599, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100e_659d, 6); if(jnzd(0x100e_6635, 0x92)) goto l_0x100e_6635; /* jnz 0x100e6635 */
            ii(0x100e_65a3, 5); mov(eax, 0x294);                        /* mov eax, 0x294 */
            ii(0x100e_65a8, 5); calld(Definitions.my_get_res_data_by_id, 0x4_da2b); /* call 0x10133fd8 */
            ii(0x100e_65ad, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_65b0, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_65b4, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_65b8, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_65ba, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_65bd, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100e_65c0, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_65c2, 2); if(jgd(0x100e_65da, 0x16)) goto l_0x100e_65da; /* jg 0x100e65da */
            ii(0x100e_65c4, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100e_65c8, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_65cc, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_65ce, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_65d1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_65d3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_65d6, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_65d8, 2); if(jled(0x100e_65df, 0x5)) goto l_0x100e_65df; /* jle 0x100e65df */
        l_0x100e_65da:
            ii(0x100e_65da, 5); jmpd(0x100e_6799, 0x1ba); goto l_0x100e_6799; /* jmp 0x100e6799 */
        l_0x100e_65df:
            ii(0x100e_65df, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_65e2, 1); pushd(eax);                             /* push eax */
            ii(0x100e_65e3, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100e_65e8, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_65ec, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_65f0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_65f2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_65f5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_65f7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_65fa, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_65fc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_65fe, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6601, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6603, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_6605, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_6608, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_660c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_6610, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_6612, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_6615, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x100e_6618, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_661a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_661c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_661e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_6621, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6623, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_6625, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_6628, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_662b, 5); calld(0x100e_8d1e, 0x26ee);             /* call 0x100e8d1e */
            ii(0x100e_6630, 5); jmpd(0x100e_6799, 0x164); goto l_0x100e_6799; /* jmp 0x100e6799 */
        l_0x100e_6635:
            ii(0x100e_6635, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_6638, 4); cmp(memb_a32[ds, eax + 0x4e], 0);       /* cmp byte [eax+0x4e], 0x0 */
            ii(0x100e_663c, 2); if(jnzd(0x100e_664b, 0xd)) goto l_0x100e_664b; /* jnz 0x100e664b */
            ii(0x100e_663e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_6641, 4); cmp(memb_a32[ds, eax + 0x50], 0);       /* cmp byte [eax+0x50], 0x0 */
            ii(0x100e_6645, 6); if(jzd(0x100e_6799, 0x14e)) goto l_0x100e_6799; /* jz 0x100e6799 */
        l_0x100e_664b:
            ii(0x100e_664b, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100e_6652, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100e_6659, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_665c, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x100e_665f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_6662, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_6665, 4); cmp(memb_a32[ds, eax + 0x4e], 0);       /* cmp byte [eax+0x4e], 0x0 */
            ii(0x100e_6669, 2); if(jzd(0x100e_669b, 0x30)) goto l_0x100e_669b; /* jz 0x100e669b */
            ii(0x100e_666b, 5); mov(eax, 0x292);                        /* mov eax, 0x292 */
            ii(0x100e_6670, 5); calld(Definitions.my_get_res_data_by_id, 0x4_d963); /* call 0x10133fd8 */
            ii(0x100e_6675, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_6678, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100e_667c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_6680, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_6682, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6685, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_6687, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_668a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_668c, 6); if(jgd(0x100e_6799, 0x107)) goto l_0x100e_6799; /* jg 0x100e6799 */
            ii(0x100e_6692, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6695, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_6698, 3); sub(memd_a32[ss, ebp - 0x20], eax);     /* sub [ebp-0x20], eax */
        l_0x100e_669b:
            ii(0x100e_669b, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100e_669f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_66a1, 2); if(jld(0x100e_66ac, 0x9)) goto l_0x100e_66ac; /* jl 0x100e66ac */
            ii(0x100e_66a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_66a6, 4); cmp(memb_a32[ds, eax + 0x50], 0);       /* cmp byte [eax+0x50], 0x0 */
            ii(0x100e_66aa, 2); if(jnzd(0x100e_66ae, 0x2)) goto l_0x100e_66ae; /* jnz 0x100e66ae */
        l_0x100e_66ac:
            ii(0x100e_66ac, 2); jmpd(0x100e_66de, 0x30); goto l_0x100e_66de; /* jmp 0x100e66de */
        l_0x100e_66ae:
            ii(0x100e_66ae, 5); mov(eax, 0x293);                        /* mov eax, 0x293 */
            ii(0x100e_66b3, 5); calld(Definitions.my_get_res_data_by_id, 0x4_d920); /* call 0x10133fd8 */
            ii(0x100e_66b8, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_66bb, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100e_66bf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_66c3, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_66c5, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_66c8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_66ca, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_66cd, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_66cf, 6); if(jgd(0x100e_6799, 0xc4)) goto l_0x100e_6799; /* jg 0x100e6799 */
            ii(0x100e_66d5, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_66d8, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_66db, 3); sub(memd_a32[ss, ebp - 0x20], eax);     /* sub [ebp-0x20], eax */
        l_0x100e_66de:
            ii(0x100e_66de, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100e_66e2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_66e4, 6); if(jld(0x100e_6799, 0xaf)) goto l_0x100e_6799; /* jl 0x100e6799 */
            ii(0x100e_66ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_66ed, 4); cmp(memb_a32[ds, eax + 0x50], 0);       /* cmp byte [eax+0x50], 0x0 */
            ii(0x100e_66f1, 2); if(jzd(0x100e_66fc, 0x9)) goto l_0x100e_66fc; /* jz 0x100e66fc */
            ii(0x100e_66f3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_66f6, 4); cmp(memb_a32[ds, eax + 0x4e], 0);       /* cmp byte [eax+0x4e], 0x0 */
            ii(0x100e_66fa, 2); if(jnzd(0x100e_66fe, 0x2)) goto l_0x100e_66fe; /* jnz 0x100e66fe */
        l_0x100e_66fc:
            ii(0x100e_66fc, 2); jmpd(0x100e_6713, 0x15); goto l_0x100e_6713; /* jmp 0x100e6713 */
        l_0x100e_66fe:
            ii(0x100e_66fe, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100e_6702, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100e_6707, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6709, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_670c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_670e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_6711, 2); jmpd(0x100e_6723, 0x10); goto l_0x100e_6723; /* jmp 0x100e6723 */
        l_0x100e_6713:
            ii(0x100e_6713, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100e_6717, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6719, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_671c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_671e, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_6720, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100e_6723:
            ii(0x100e_6723, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_6726, 4); cmp(memb_a32[ds, eax + 0x4e], 0);       /* cmp byte [eax+0x4e], 0x0 */
            ii(0x100e_672a, 2); if(jzd(0x100e_6766, 0x3a)) goto l_0x100e_6766; /* jz 0x100e6766 */
            ii(0x100e_672c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_672f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6730, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100e_6735, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6738, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x100e_673b, 4); sub(dx, memw_a32[ds, eax + 0x2]);       /* sub dx, [eax+0x2] */
            ii(0x100e_673f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6741, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6742, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_6745, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_6748, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x100e_674b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_674e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_6751, 5); calld(0x100e_8d1e, 0x25c8);             /* call 0x100e8d1e */
            ii(0x100e_6756, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100e_6759, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100e_675b, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_675e, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_6761, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_6763, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100e_6766:
            ii(0x100e_6766, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_6769, 4); cmp(memb_a32[ds, eax + 0x50], 0);       /* cmp byte [eax+0x50], 0x0 */
            ii(0x100e_676d, 2); if(jzd(0x100e_6799, 0x2a)) goto l_0x100e_6799; /* jz 0x100e6799 */
            ii(0x100e_676f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_6772, 1); pushd(eax);                             /* push eax */
            ii(0x100e_6773, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100e_6778, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_677b, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x100e_677e, 4); sub(dx, memw_a32[ds, eax + 0x2]);       /* sub dx, [eax+0x2] */
            ii(0x100e_6782, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_6784, 1); dec(eax);                               /* dec eax */
            ii(0x100e_6785, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_6788, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_678b, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x100e_678e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_6791, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_6794, 5); calld(0x100e_8d1e, 0x2585);             /* call 0x100e8d1e */
        l_0x100e_6799:
            ii(0x100e_6799, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_679b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_679c, 1); popd(edi);                              /* pop edi */
            ii(0x100e_679d, 1); popd(esi);                              /* pop esi */
            ii(0x100e_679e, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
