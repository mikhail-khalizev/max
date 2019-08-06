using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("80fa3c10-d5a2-4f80-a7eb-e75d78bd4a1c")]
        public void /* sys */ Method_1018_1fde()
        {
            ii(0x1018_1fde, 7); mov(memb_a32[ds, 0x101b_ddac], 0x3);    /* mov byte [0x101bddac], 0x3 */
            ii(0x1018_1fe5, 7); mov(memb_a32[ds, 0x101b_e814], 0x1);    /* mov byte [0x101be814], 0x1 */
            ii(0x1018_1fec, 8); smsw(memw_a32[ds, 0x101b_e812]);        /* smsw word [0x101be812] */
            ii(0x1018_1ff4, 8); and(memw_a32[ds, 0x101b_e812], 0x6);    /* and word [0x101be812], 0x6 */
            ii(0x1018_1ffc, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1018_1fff, 4); sidtd_a32(ss, esp);                     /* sidt [esp] */
            ii(0x1018_2003, 4); mov(ebx, memd_a32[ss, esp + 0x2]);      /* mov ebx, [esp+0x2] */
            ii(0x1018_2007, 3); add(ebx, 0x38);                         /* add ebx, 0x38 */
            ii(0x1018_200a, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1018_200d, 7); cmp(memb_a32[ds, 0x101b_e590], 0);      /* cmp byte [0x101be590], 0x0 */
            ii(0x1018_2014, 2); if(jzd(0x1018_2030, 0x1a)) goto l_0x1018_2030; /* jz 0x10182030 */
            ii(0x1018_2016, 5); calld(/* sys */ 0x1018_20a9, 0x8e);     /* call 0x101820a9 */
            ii(0x1018_201b, 7); mov(es, memw_a32[ds, 0x101b_de92]);     /* mov es, [0x101bde92] */
            ii(0x1018_2022, 3); mov(memd_a32[es, ebx], edx);            /* mov [es:ebx], edx */
            ii(0x1018_2025, 4); mov(memd_a32[es, ebx + 0x4], ecx);      /* mov [es:ebx+0x4], ecx */
            ii(0x1018_2029, 5); calld(/* sys */ 0x1018_2113, 0xe5);     /* call 0x10182113 */
            ii(0x1018_202e, 2); jmpd(0x1018_20a8, 0x78); goto l_0x1018_20a8; /* jmp 0x101820a8 */
        l_0x1018_2030:
            ii(0x1018_2030, 7); cmp(memb_a32[ds, 0x101b_e58e], 0);      /* cmp byte [0x101be58e], 0x0 */
            ii(0x1018_2037, 2); if(jnzd(0x1018_2054, 0x1b)) goto l_0x1018_2054; /* jnz 0x10182054 */
            ii(0x1018_2039, 4); mov(ax, 0x2507);                        /* mov ax, 0x2507 */
            ii(0x1018_203d, 1); pushd(ds);                              /* push ds */
            ii(0x1018_203e, 3); mov(cx, cs);                            /* mov cx, cs */
            ii(0x1018_2041, 2); mov(ds, ecx);                           /* mov ds, ecx */
            ii(0x1018_2043, 6); lea(edx, /* sys */ 0x1019_6c4c);        /* lea edx, [0x10196c4c] */
            ii(0x1018_2049, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_204b, 1); popd(ds);                               /* pop ds */
            ii(0x1018_204c, 2); mov(al, 0x4);                           /* mov al, 0x4 */
            ii(0x1018_204e, 2); mov(ah, 0xf3);                          /* mov ah, 0xf3 */
            ii(0x1018_2050, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_2052, 2); jmpd(0x1018_20a8, 0x54); goto l_0x1018_20a8; /* jmp 0x101820a8 */
        l_0x1018_2054:
            ii(0x1018_2054, 7); cmp(memb_a32[ds, 0x101b_e58e], 0x9);    /* cmp byte [0x101be58e], 0x9 */
            ii(0x1018_205b, 2); if(jnzd(0x1018_207c, 0x1f)) goto l_0x1018_207c; /* jnz 0x1018207c */
            ii(0x1018_205d, 5); calld(/* sys */ 0x1018_20a9, 0x47);     /* call 0x101820a9 */
            ii(0x1018_2062, 2); mov(memd_a32[ds, ebx], edx);            /* mov [ebx], edx */
            ii(0x1018_2064, 3); mov(memd_a32[ds, ebx + 0x4], ecx);      /* mov [ebx+0x4], ecx */
            ii(0x1018_2067, 5); mov(eax, 0xe02);                        /* mov eax, 0xe02 */
            ii(0x1018_206c, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1018_2071, 6); mov(ecx, memd_a32[ds, 0x101b_de8c]);    /* mov ecx, [0x101bde8c] */
            ii(0x1018_2077, 3); calld_abs(memd_a32[ds, ecx + 0x30]);    /* call dword [ecx+0x30] */
            ii(0x1018_207a, 2); jmpd(0x1018_20a8, 0x2c); goto l_0x1018_20a8; /* jmp 0x101820a8 */
        l_0x1018_207c:
            ii(0x1018_207c, 7); cmp(memb_a32[ds, 0x101b_e58e], 0x1);    /* cmp byte [0x101be58e], 0x1 */
            ii(0x1018_2083, 2); if(jnzd(0x1018_2095, 0x10)) goto l_0x1018_2095; /* jnz 0x10182095 */
            ii(0x1018_2085, 7); mov(dx, memw_a32[ds, 0x101b_de90]);     /* mov dx, [0x101bde90] */
            ii(0x1018_208c, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1018_208e, 5); calld(/* sys */ 0x1019_9a8a, 0x179f7);  /* call 0x10199a8a */
            ii(0x1018_2093, 2); jmpd(0x1018_20a8, 0x13); goto l_0x1018_20a8; /* jmp 0x101820a8 */
        l_0x1018_2095:
            ii(0x1018_2095, 3); sub(dx, dx);                            /* sub dx, dx */
            ii(0x1018_2098, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1018_209a, 5); calld(/* sys */ 0x1019_9a8a, 0x179eb);  /* call 0x10199a8a */
            ii(0x1018_209f, 2); cmp(al, 0x1);                           /* cmp al, 0x1 */
            ii(0x1018_20a1, 2); if(jzd(0x1018_20a8, 0x5)) goto l_0x1018_20a8; /* jz 0x101820a8 */
            ii(0x1018_20a3, 5); calld(/* sys */ 0x1018_20c6, 0x1e);     /* call 0x101820c6 */
        l_0x1018_20a8:
            ii(0x1018_20a8, 1); retd(); return;                         /* ret */
        }
    }
}
