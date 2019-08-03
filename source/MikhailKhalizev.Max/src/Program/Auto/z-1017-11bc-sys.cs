using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9a16cb07-8d11-492b-8e21-9d7f4c240db0")]
        public void /* sys */ Method_1017_11bc()
        {
            ii(0x1017_11bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_11bd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_11be, 1); pushd(edx);                             /* push edx */
            ii(0x1017_11bf, 1); pushd(esi);                             /* push esi */
            ii(0x1017_11c0, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_11c3, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_11c5, 4); test(memb_a32[ds, eax + 0x4], 0x8);     /* test byte [eax+0x4], 0x8 */
            ii(0x1017_11c9, 6); if(jzd(0x1017_1272, 0xa3)) goto l_0x1017_1272; /* jz 0x10171272 */
            ii(0x1017_11cf, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1017_11d2, 5); and(eax, 0xf0);                         /* and eax, 0xf0 */
            ii(0x1017_11d7, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1017_11da, 6); if(jnzd(0x1017_1272, 0x92)) goto l_0x1017_1272; /* jnz 0x10171272 */
            ii(0x1017_11e0, 4); cmp(memd_a32[ds, esi + 0x10], 0);       /* cmp dword [esi+0x10], 0x0 */
            ii(0x1017_11e4, 6); if(jbed(0x1017_1272, 0x88)) goto l_0x1017_1272; /* jbe 0x10171272 */
            ii(0x1017_11ea, 3); mov(eax, memd_a32[ds, esi + 0x1c]);     /* mov eax, [esi+0x1c] */
            ii(0x1017_11ed, 3); mov(ebx, memd_a32[ds, esi + 0x20]);     /* mov ebx, [esi+0x20] */
            ii(0x1017_11f0, 5); add(eax, 0x4000);                       /* add eax, 0x4000 */
            ii(0x1017_11f5, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1017_11f7, 6); if(jad(0x1017_1272, 0x75)) goto l_0x1017_1272; /* ja 0x10171272 */
            ii(0x1017_11fd, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1017_11ff, 3); mov(edx, memd_a32[ds, esi + 0x18]);     /* mov edx, [esi+0x18] */
            ii(0x1017_1202, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_1204, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1017_1207, 5); calld(Definitions.sys_fseek, 0x1264);   /* call 0x10172470 */
            ii(0x1017_120c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_120e, 2); if(jnzd(0x1017_1272, 0x62)) goto l_0x1017_1272; /* jnz 0x10171272 */
            ii(0x1017_1210, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1017_1212, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_1214, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1017_1217, 5); calld(/* sys */ 0x1017_127c, 0x60);     /* call 0x1017127c */
            ii(0x1017_121c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_121e, 2); if(jnzd(0x1017_1272, 0x52)) goto l_0x1017_1272; /* jnz 0x10171272 */
            ii(0x1017_1220, 4); mov(dl, memb_a32[ss, esp + 0x1]);       /* mov dl, [esp+0x1] */
            ii(0x1017_1224, 3); test(dl, 0x80);                         /* test dl, 0x80 */
            ii(0x1017_1227, 2); if(jzd(0x1017_124c, 0x23)) goto l_0x1017_124c; /* jz 0x1017124c */
            ii(0x1017_1229, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1017_122b, 3); and(dh, 0x7f);                          /* and dh, 0x7f */
            ii(0x1017_122e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_1230, 4); mov(memb_a32[ss, esp + 0x1], dh);       /* mov [esp+0x1], dh */
            ii(0x1017_1234, 4); mov(bx, memw_a32[ss, esp]);             /* mov bx, [esp] */
            ii(0x1017_1238, 2); mov(ecx, memd_a32[ds, esi]);            /* mov ecx, [esi] */
            ii(0x1017_123a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1017_123f, 3); mov(eax, memd_a32[ds, esi + 0x1c]);     /* mov eax, [esi+0x1c] */
            ii(0x1017_1242, 3); mov(ecx, memd_a32[ds, ecx + 0x4]);      /* mov ecx, [ecx+0x4] */
            ii(0x1017_1245, 5); calld(Definitions.sys_fread, 0x1322);   /* call 0x1017256c */
            ii(0x1017_124a, 2); jmpd(0x1017_125f, 0x13); goto l_0x1017_125f; /* jmp 0x1017125f */
        l_0x1017_124c:
            ii(0x1017_124c, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1017_124e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_1250, 3); mov(edx, memd_a32[ds, esi + 0x1c]);     /* mov edx, [esi+0x1c] */
            ii(0x1017_1253, 4); mov(bx, memw_a32[ss, esp]);             /* mov bx, [esp] */
            ii(0x1017_1257, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1017_125a, 5); calld(/* sys */ 0x1018_7f50, 0x16cf1);  /* call 0x10187f50 */
        l_0x1017_125f:
            ii(0x1017_125f, 3); mov(eax, memd_a32[ds, esi + 0x1c]);     /* mov eax, [esi+0x1c] */
            ii(0x1017_1262, 3); mov(memd_a32[ds, esi + 0x20], eax);     /* mov [esi+0x20], eax */
            ii(0x1017_1265, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1017_1267, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1017_126a, 5); calld(Definitions.sys_ftell, 0x14d8);   /* call 0x10172747 */
            ii(0x1017_126f, 3); mov(memd_a32[ds, esi + 0x18], eax);     /* mov [esi+0x18], eax */
        l_0x1017_1272:
            ii(0x1017_1272, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_1275, 1); popd(esi);                              /* pop esi */
            ii(0x1017_1276, 1); popd(edx);                              /* pop edx */
            ii(0x1017_1277, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_1278, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_1279, 1); retd(); return;                         /* ret */
        }
    }
}
