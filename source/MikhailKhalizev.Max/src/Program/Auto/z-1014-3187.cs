using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_3187-541c7a11")]
        public void Method_1014_3187()
        {
            ii(0x1014_3187, 5); pushd(0xc4);                            /* push 0xc4 */
            ii(0x1014_318c, 5); calld(Definitions.sys_check_available_stack_size, 0x2_2bc1); /* call 0x10165d52 */
            ii(0x1014_3191, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_3192, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_3193, 1); pushd(edx);                             /* push edx */
            ii(0x1014_3194, 1); pushd(esi);                             /* push esi */
            ii(0x1014_3195, 1); pushd(edi);                             /* push edi */
            ii(0x1014_3196, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_3197, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_3199, 6); sub(esp, 0x98);                         /* sub esp, 0x98 */
            ii(0x1014_319f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_31a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_31a5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_31a7, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1014_31aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_31ad, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1014_31b1, 4); mov(memw_a32[ss, ebp - 0x2c], ax);      /* mov [ebp-0x2c], ax */
            ii(0x1014_31b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_31b8, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_31bb, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1014_31be, 7); mov(memd_a32[ss, ebp - 0x2a], 0xae);    /* mov dword [ebp-0x2a], 0xae */
            ii(0x1014_31c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_31c8, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1014_31cb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_31ce, 3); mov(memd_a32[ss, ebp - 0x26], eax);     /* mov [ebp-0x26], eax */
            ii(0x1014_31d1, 7); mov(memd_a32[ss, ebp - 0x22], 0x19e);   /* mov dword [ebp-0x22], 0x19e */
            ii(0x1014_31d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_31db, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1014_31de, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_31e1, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x1014_31e4, 3); mov(memd_a32[ss, ebp - 0x1e], eax);     /* mov [ebp-0x1e], eax */
            ii(0x1014_31e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_31ea, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1014_31ee, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x1014_31f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_31f5, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x1014_31f9, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x1014_31fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3200, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1014_3204, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1014_3208, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x1014_320f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3212, 4); mov(ax, memw_a32[ds, eax + 0x18]);      /* mov ax, [eax+0x18] */
            ii(0x1014_3216, 4); mov(memw_a32[ss, ebp - 0xc], ax);       /* mov [ebp-0xc], ax */
            ii(0x1014_321a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_321d, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1014_3221, 4); mov(memw_a32[ss, ebp - 0xa], ax);       /* mov [ebp-0xa], ax */
            ii(0x1014_3225, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3228, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1014_322b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_322e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_3231, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_3234, 4); cmp(ax, memw_a32[ds, edx + 0x12]);      /* cmp ax, [edx+0x12] */
            ii(0x1014_3238, 2); if(jged(0x1014_3245, 0xb)) goto l_0x1014_3245; /* jge 0x10143245 */
            ii(0x1014_323a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_323d, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1014_3241, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
        l_0x1014_3245:
            ii(0x1014_3245, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3248, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1014_324b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_324e, 1); pushd(eax);                             /* push eax */
            ii(0x1014_324f, 5); mov(eax, StringDefinitions.I19);        /* mov eax, 0x101acee4 */
            ii(0x1014_3254, 1); pushd(eax);                             /* push eax */
            ii(0x1014_3255, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x1014_325b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_325c, 5); calld(Definitions.sys_sprintf, 0x2_2ca0); /* call 0x10165f01 */
            ii(0x1014_3261, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1014_3264, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x1014_326a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_326d, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_3270, 5); calld(0x1014_2e97, -0x3de);             /* call 0x10142e97 */
            ii(0x1014_3275, 4); add(memd_a32[ss, ebp - 0x26], 0x25);    /* add dword [ebp-0x26], 0x25 */
            ii(0x1014_3279, 4); add(memd_a32[ss, ebp - 0x1e], 0x25);    /* add dword [ebp-0x1e], 0x25 */
            ii(0x1014_327d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3280, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1014_3284, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x1014_3288, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1014_328f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3292, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x1014_3295, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_3298, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_329b, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1014_329e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_32a1, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_32a3, 1); pushd(edx);                             /* push edx */
            ii(0x1014_32a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_32a7, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1014_32aa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_32ad, 1); pushd(eax);                             /* push eax */
            ii(0x1014_32ae, 5); mov(eax, StringDefinitions.IITurn);     /* mov eax, 0x101acee7 */
            ii(0x1014_32b3, 1); pushd(eax);                             /* push eax */
            ii(0x1014_32b4, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x1014_32ba, 1); pushd(eax);                             /* push eax */
            ii(0x1014_32bb, 5); calld(Definitions.sys_sprintf, 0x2_2c41); /* call 0x10165f01 */
            ii(0x1014_32c0, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1014_32c3, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_32c6, 5); calld(0x1014_2e97, -0x434);             /* call 0x10142e97 */
            ii(0x1014_32cb, 4); add(memd_a32[ss, ebp - 0x26], 0x25);    /* add dword [ebp-0x26], 0x25 */
            ii(0x1014_32cf, 4); add(memd_a32[ss, ebp - 0x1e], 0x25);    /* add dword [ebp-0x1e], 0x25 */
            ii(0x1014_32d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_32d6, 4); mov(ax, memw_a32[ds, eax + 0x14]);      /* mov ax, [eax+0x14] */
            ii(0x1014_32da, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x1014_32de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_32e1, 4); mov(ax, memw_a32[ds, eax + 0x16]);      /* mov ax, [eax+0x16] */
            ii(0x1014_32e5, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1014_32e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_32ec, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1014_32ef, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_32f2, 1); pushd(eax);                             /* push eax */
            ii(0x1014_32f3, 5); mov(eax, StringDefinitions.I20);        /* mov eax, 0x101acef7 */
            ii(0x1014_32f8, 1); pushd(eax);                             /* push eax */
            ii(0x1014_32f9, 6); lea(eax, ebp - 0x98);                   /* lea eax, [ebp-0x98] */
            ii(0x1014_32ff, 1); pushd(eax);                             /* push eax */
            ii(0x1014_3300, 5); calld(Definitions.sys_sprintf, 0x2_2bfc); /* call 0x10165f01 */
            ii(0x1014_3305, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1014_3308, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1014_330b, 5); calld(0x1014_2e97, -0x479);             /* call 0x10142e97 */
            ii(0x1014_3310, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_3312, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_3313, 1); popd(edi);                              /* pop edi */
            ii(0x1014_3314, 1); popd(esi);                              /* pop esi */
            ii(0x1014_3315, 1); popd(edx);                              /* pop edx */
            ii(0x1014_3316, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_3317, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_3318, 1); retd();                                 /* ret */
        }
    }
}
