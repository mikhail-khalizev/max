using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("31f59fde-7e8d-4e2a-b49c-5469fb9ef3ae")]
        public void Method_1012_e37c()
        {
            ii(0x1012_e37c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_e381, 5); calld(Definitions.sys_check_available_stack_size, 0x3_79cc); /* call 0x10165d52 */
            ii(0x1012_e386, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_e387, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_e388, 1); pushd(esi);                             /* push esi */
            ii(0x1012_e389, 1); pushd(edi);                             /* push edi */
            ii(0x1012_e38a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_e38b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e38d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_e393, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_e396, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_e399, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_e39c, 3); add(edx, 0x36);                         /* add edx, 0x36 */
            ii(0x1012_e39f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_e3a2, 5); calld(0x1007_6d98, -0xb_760f);          /* call 0x10076d98 */
            ii(0x1012_e3a7, 2); test(al, al);                           /* test al, al */
            ii(0x1012_e3a9, 2); if(jzd(0x1012_e3b5, 0xa)) goto l_0x1012_e3b5; /* jz 0x1012e3b5 */
            ii(0x1012_e3ab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e3ae, 7); mov(memb_a32[ds, eax + 0x9d], 0x1);     /* mov byte [eax+0x9d], 0x1 */
        l_0x1012_e3b5:
            ii(0x1012_e3b5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_e3b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e3bb, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_e3be, 5); calld(0x1013_1c3c, 0x3879);             /* call 0x10131c3c */
            ii(0x1012_e3c3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_e3c6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e3c9, 5); calld(0x1012_e2a7, -0x127);             /* call 0x1012e2a7 */
            ii(0x1012_e3ce, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_e3d1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_e3d4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_e3d7, 2); jmpd(0x1012_e3df, 0x6); goto l_0x1012_e3df; /* jmp 0x1012e3df */
        l_0x1012_e3d9:
            ii(0x1012_e3d9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_e3dc, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1012_e3df:
            ii(0x1012_e3df, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e3e2, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e3e5, 5); calld(Definitions.my_1_get_count, -0x8_2f12); /* call 0x100ab4d8 */
            ii(0x1012_e3ea, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1012_e3ee, 2); if(jled(0x1012_e409, 0x19)) goto l_0x1012_e409; /* jle 0x1012e409 */
            ii(0x1012_e3f0, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e3f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e3f7, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e3fa, 5); calld(0x1013_18f8, 0x34f9);             /* call 0x101318f8 */
            ii(0x1012_e3ff, 5); calld(0x1013_19f4, 0x35f0);             /* call 0x101319f4 */
            ii(0x1012_e404, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1012_e407, 2); if(jzd(0x1012_e3d9, -0x30)) goto l_0x1012_e3d9; /* jz 0x1012e3d9 */
        l_0x1012_e409:
            ii(0x1012_e409, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e40c, 3); mov(edx, memd_a32[ds, eax + 0x32]);     /* mov edx, [eax+0x32] */
            ii(0x1012_e40f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_e412, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e415, 3); mov(eax, memd_a32[ds, eax + 0x3c]);     /* mov eax, [eax+0x3c] */
            ii(0x1012_e418, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_e41b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_e41d, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e421, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_e423, 2); if(jled(0x1012_e438, 0x13)) goto l_0x1012_e438; /* jle 0x1012e438 */
            ii(0x1012_e425, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e428, 4); mov(dx, memw_a32[ds, eax + 0x3e]);      /* mov dx, [eax+0x3e] */
            ii(0x1012_e42c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e42f, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1012_e432, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1012_e434, 4); mov(memw_a32[ds, eax + 0x34], bx);      /* mov [eax+0x34], bx */
        l_0x1012_e438:
            ii(0x1012_e438, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_e43b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_e43e, 4); cmp(ax, memw_a32[ds, edx + 0x34]);      /* cmp ax, [edx+0x34] */
            ii(0x1012_e442, 2); if(jged(0x1012_e44e, 0xa)) goto l_0x1012_e44e; /* jge 0x1012e44e */
            ii(0x1012_e444, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_e447, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_e44a, 4); mov(memw_a32[ds, edx + 0x34], ax);      /* mov [edx+0x34], ax */
        l_0x1012_e44e:
            ii(0x1012_e44e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e451, 3); mov(edx, memd_a32[ds, eax + 0x32]);     /* mov edx, [eax+0x32] */
            ii(0x1012_e454, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_e457, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e45a, 3); mov(eax, memd_a32[ds, eax + 0x3c]);     /* mov eax, [eax+0x3c] */
            ii(0x1012_e45d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_e460, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_e462, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e465, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e468, 5); calld(Definitions.my_1_get_count, -0x8_2f95); /* call 0x100ab4d8 */
            ii(0x1012_e46d, 1); cwde();                                 /* cwde */
            ii(0x1012_e46e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_e470, 2); if(jled(0x1012_e48f, 0x1d)) goto l_0x1012_e48f; /* jle 0x1012e48f */
            ii(0x1012_e472, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e475, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_e478, 5); calld(Definitions.my_1_get_count, -0x8_2fa5); /* call 0x100ab4d8 */
            ii(0x1012_e47d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e47f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e482, 4); mov(bx, memw_a32[ds, eax + 0x3e]);      /* mov bx, [eax+0x3e] */
            ii(0x1012_e486, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e489, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1012_e48b, 4); mov(memw_a32[ds, eax + 0x34], dx);      /* mov [eax+0x34], dx */
        l_0x1012_e48f:
            ii(0x1012_e48f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e492, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_e495, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_e498, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_e49a, 2); if(jged(0x1012_e4a5, 0x9)) goto l_0x1012_e4a5; /* jge 0x1012e4a5 */
            ii(0x1012_e49c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e49f, 6); mov(memw_a32[ds, eax + 0x34], 0);       /* mov word [eax+0x34], 0x0 */
        l_0x1012_e4a5:
            ii(0x1012_e4a5, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_e4aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e4ad, 5); calld(0x1013_0c16, 0x2764);             /* call 0x10130c16 */
            ii(0x1012_e4b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e4b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_e4b5, 1); popd(edi);                              /* pop edi */
            ii(0x1012_e4b6, 1); popd(esi);                              /* pop esi */
            ii(0x1012_e4b7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_e4b8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_e4b9, 1); retd(); return;                         /* ret */
        }
    }
}
