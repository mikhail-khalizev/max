using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("46adedac-db96-4ef0-aeb1-db5a85af1a52")]
        public void Method_1011_11dc()
        {
            ii(0x1011_11dc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_11e1, 5); calld(Definitions.sys_check_available_stack_size, 0x54b6c); /* call 0x10165d52 */
            ii(0x1011_11e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_11e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_11e8, 1); pushd(edx);                             /* push edx */
            ii(0x1011_11e9, 1); pushd(esi);                             /* push esi */
            ii(0x1011_11ea, 1); pushd(edi);                             /* push edi */
            ii(0x1011_11eb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_11ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_11ee, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_11f4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_11f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_11fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_11fc, 6); mov(dl, memb_a32[ds, eax + 0x140]);     /* mov dl, [eax+0x140] */
            ii(0x1011_1202, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1205, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1011_1209, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_120b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_120e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1211, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_1213, 6); mov(dl, memb_a32[ds, eax + 0x142]);     /* mov dl, [eax+0x142] */
            ii(0x1011_1219, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_121d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_121f, 2); if(jnzd(0x1011_1230, 0xf)) goto l_0x1011_1230; /* jnz 0x10111230 */
            ii(0x1011_1221, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1224, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1011_122b, 5); jmpd(0x1011_12ac, 0x7c); goto l_0x1011_12ac; /* jmp 0x101112ac */
        l_0x1011_1230:
            ii(0x1011_1230, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1233, 6); mov(dl, memb_a32[ds, eax + 0x142]);     /* mov dl, [eax+0x142] */
            ii(0x1011_1239, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_123c, 6); cmp(dl, memb_a32[ds, eax + 0x140]);     /* cmp dl, [eax+0x140] */
            ii(0x1011_1242, 2); if(jbd(0x1011_1264, 0x20)) goto l_0x1011_1264; /* jb 0x10111264 */
            ii(0x1011_1244, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1247, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_1249, 6); mov(dl, memb_a32[ds, eax + 0x140]);     /* mov dl, [eax+0x140] */
            ii(0x1011_124f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1252, 6); mov(al, memb_a32[ds, eax + 0x142]);     /* mov al, [eax+0x142] */
            ii(0x1011_1258, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_125d, 3); add(edx, 0xc);                          /* add edx, 0xc */
            ii(0x1011_1260, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1011_1262, 2); if(jld(0x1011_1266, 0x2)) goto l_0x1011_1266; /* jl 0x10111266 */
        l_0x1011_1264:
            ii(0x1011_1264, 2); jmpd(0x1011_1290, 0x2a); goto l_0x1011_1290; /* jmp 0x10111290 */
        l_0x1011_1266:
            ii(0x1011_1266, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_126b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_126e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_1270, 6); mov(dl, memb_a32[ds, eax + 0x142]);     /* mov dl, [eax+0x142] */
            ii(0x1011_1276, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1279, 6); mov(al, memb_a32[ds, eax + 0x140]);     /* mov al, [eax+0x140] */
            ii(0x1011_127f, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_1281, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_1283, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_1285, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_1288, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_128b, 5); calld(0x1011_0296, -0xffa);             /* call 0x10110296 */
        l_0x1011_1290:
            ii(0x1011_1290, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_1293, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_1296, 6); mov(memb_a32[ds, edx + 0x142], al);     /* mov [edx+0x142], al */
            ii(0x1011_129c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_129f, 5); calld(0x1011_09f0, -0x8b4);             /* call 0x101109f0 */
            ii(0x1011_12a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_12a7, 5); calld(0x1011_0496, -0xe16);             /* call 0x10110496 */
        l_0x1011_12ac:
            ii(0x1011_12ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_12ae, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_12af, 1); popd(edi);                              /* pop edi */
            ii(0x1011_12b0, 1); popd(esi);                              /* pop esi */
            ii(0x1011_12b1, 1); popd(edx);                              /* pop edx */
            ii(0x1011_12b2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_12b3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_12b4, 1); retd(); return;                         /* ret */
        }
    }
}
