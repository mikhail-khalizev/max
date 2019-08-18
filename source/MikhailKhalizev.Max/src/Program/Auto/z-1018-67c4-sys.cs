using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_67c4-4bb09135")]
        public void /* sys */ Method_1018_67c4()
        {
            ii(0x1018_67c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_67c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_67c6, 1); pushd(esi);                             /* push esi */
            ii(0x1018_67c7, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_67c9, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_67cb, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1018_67cd, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_67cf, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_67d1, 5); calld(/* sys */ 0x1016_f6e8, -0x1_70ee); /* call 0x1016f6e8 */
            ii(0x1018_67d6, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_67d9, 6); if(jzd(0x1018_6891, 0xb2)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_67df, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_67e1, 3); mov(edx, memd_a32[ds, ecx + 0x4]);      /* mov edx, [ecx+0x4] */
            ii(0x1018_67e4, 5); calld(/* sys */ 0x1016_f6e8, -0x1_7101); /* call 0x1016f6e8 */
            ii(0x1018_67e9, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_67ec, 6); if(jzd(0x1018_6891, 0x9f)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_67f2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_67f4, 3); mov(edx, memd_a32[ds, ecx + 0x8]);      /* mov edx, [ecx+0x8] */
            ii(0x1018_67f7, 5); calld(/* sys */ 0x1016_f6e8, -0x1_7114); /* call 0x1016f6e8 */
            ii(0x1018_67fc, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_67ff, 6); if(jzd(0x1018_6891, 0x8c)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_6805, 2); mov(eax, memd_a32[ds, ecx]);            /* mov eax, [ecx] */
            ii(0x1018_6807, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1018_680a, 6); if(jad(0x1018_6891, 0x81)) goto l_0x1018_6891; /* ja 0x10186891 */
            ii(0x1018_6810, 8); 
            switch (jmpd_abs_switch(memd_a32[cs, eax * 4 + /* sys */ 0x1018_67b4]))
            {
                case 0x1018_6818:
                    goto l_0x1018_6818;
                case 0x1018_684b:
                    goto l_0x1018_684b;
                case 0x1018_685f:
                    goto l_0x1018_685f;
                case 0x1018_6891:
                    goto l_0x1018_6891;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax*4+0x101867b4] */
        l_0x1018_6818:
            ii(0x1018_6818, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_681a, 3); mov(edx, memd_a32[ds, ecx + 0xc]);      /* mov edx, [ecx+0xc] */
            ii(0x1018_681d, 5); calld(/* sys */ 0x1016_f6e8, -0x1_713a); /* call 0x1016f6e8 */
            ii(0x1018_6822, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_6825, 6); if(jzd(0x1018_6891, 0x66)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_682b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_682d, 3); mov(edx, memd_a32[ds, ecx + 0x10]);     /* mov edx, [ecx+0x10] */
            ii(0x1018_6830, 5); calld(/* sys */ 0x1016_f6e8, -0x1_714d); /* call 0x1016f6e8 */
            ii(0x1018_6835, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_6838, 2); if(jzd(0x1018_6891, 0x57)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_683a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_683c, 3); mov(edx, memd_a32[ds, ecx + 0x14]);     /* mov edx, [ecx+0x14] */
            ii(0x1018_683f, 5); calld(/* sys */ 0x1016_f6e8, -0x1_715c); /* call 0x1016f6e8 */
            ii(0x1018_6844, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_6847, 2); if(jzd(0x1018_6891, 0x48)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_6849, 2); jmpd(0x1018_688c, 0x41); goto l_0x1018_688c; /* jmp 0x1018688c */
        l_0x1018_684b:
            ii(0x1018_684b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_684d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_684f, 4); mov(dx, memw_a32[ds, ecx + 0xc]);       /* mov dx, [ecx+0xc] */
            ii(0x1018_6853, 5); calld(/* sys */ 0x1016_f66c, -0x1_71ec); /* call 0x1016f66c */
            ii(0x1018_6858, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_685b, 2); if(jzd(0x1018_6891, 0x34)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_685d, 2); jmpd(0x1018_688c, 0x2d); goto l_0x1018_688c; /* jmp 0x1018688c */
        l_0x1018_685f:
            ii(0x1018_685f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6861, 3); mov(edx, memd_a32[ds, ecx + 0xc]);      /* mov edx, [ecx+0xc] */
            ii(0x1018_6864, 5); calld(/* sys */ 0x1016_f6e8, -0x1_7181); /* call 0x1016f6e8 */
            ii(0x1018_6869, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_686c, 2); if(jzd(0x1018_6891, 0x23)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_686e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6870, 3); mov(edx, memd_a32[ds, ecx + 0x10]);     /* mov edx, [ecx+0x10] */
            ii(0x1018_6873, 5); calld(/* sys */ 0x1016_f6e8, -0x1_7190); /* call 0x1016f6e8 */
            ii(0x1018_6878, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_687b, 2); if(jzd(0x1018_6891, 0x14)) goto l_0x1018_6891; /* jz 0x10186891 */
            ii(0x1018_687d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_687f, 3); mov(edx, memd_a32[ds, ecx + 0x14]);     /* mov edx, [ecx+0x14] */
            ii(0x1018_6882, 5); calld(/* sys */ 0x1016_f6e8, -0x1_719f); /* call 0x1016f6e8 */
            ii(0x1018_6887, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_688a, 2); if(jzd(0x1018_6891, 0x5)) goto l_0x1018_6891; /* jz 0x10186891 */
        l_0x1018_688c:
            ii(0x1018_688c, 5); mov(esi, 0x1);                          /* mov esi, 0x1 */
        l_0x1018_6891:
            ii(0x1018_6891, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_6893, 1); popd(esi);                              /* pop esi */
            ii(0x1018_6894, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_6895, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_6896, 1); retd(); return;                         /* ret */
        }
    }
}
