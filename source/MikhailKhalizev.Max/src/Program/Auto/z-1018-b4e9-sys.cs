using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e33de68d-e912-4893-bd0b-efbceee33416")]
        public void /* sys */ Method_1018_b4e9()
        {
            ii(0x1018_b4e9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_b4ea, 1); pushd(esi);                             /* push esi */
            ii(0x1018_b4eb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_b4ec, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_b4ee, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_b4f1, 6); if(jzd(0x1018_b565, 0x6e)) goto l_0x1018_b565; /* jz 0x1018b565 */
            ii(0x1018_b4f7, 4); test(memb_a32[ds, edx + 0xd], 0x10);    /* test byte [edx+0xd], 0x10 */
            ii(0x1018_b4fb, 2); if(jzd(0x1018_b504, 0x7)) goto l_0x1018_b504; /* jz 0x1018b504 */
        l_0x1018_b4fd:
            ii(0x1018_b4fd, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1018_b502, 2); jmpd(0x1018_b565, 0x61); goto l_0x1018_b565; /* jmp 0x1018b565 */
        l_0x1018_b504:
            ii(0x1018_b504, 4); test(memb_a32[ds, edx + 0xc], 0x1);     /* test byte [edx+0xc], 0x1 */
            ii(0x1018_b508, 2); if(jzd(0x1018_b4fd, -0xd)) goto l_0x1018_b4fd; /* jz 0x1018b4fd */
            ii(0x1018_b50a, 4); cmp(memd_a32[ds, edx + 0x8], 0);        /* cmp dword [edx+0x8], 0x0 */
            ii(0x1018_b50e, 2); if(jnzd(0x1018_b517, 0x7)) goto l_0x1018_b517; /* jnz 0x1018b517 */
            ii(0x1018_b510, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_b512, 5); calld(/* sys */ 0x1018_d3ee, 0x1ed7);   /* call 0x1018d3ee */
        l_0x1018_b517:
            ii(0x1018_b517, 3); mov(esi, memd_a32[ds, edx + 0x4]);      /* mov esi, [edx+0x4] */
            ii(0x1018_b51a, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_b51c, 2); if(jnzd(0x1018_b536, 0x18)) goto l_0x1018_b536; /* jnz 0x1018b536 */
            ii(0x1018_b51e, 3); mov(eax, memd_a32[ds, edx + 0x8]);      /* mov eax, [edx+0x8] */
            ii(0x1018_b521, 3); add(eax, memd_a32[ds, edx + 0x14]);     /* add eax, [edx+0x14] */
            ii(0x1018_b524, 1); dec(eax);                               /* dec eax */
            ii(0x1018_b525, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1018_b527, 4); or(memb_a32[ds, edx + 0xc], 0x4);       /* or byte [edx+0xc], 0x4 */
            ii(0x1018_b52b, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1018_b52d, 7); mov(memd_a32[ds, edx + 0x4], 0x1);      /* mov dword [edx+0x4], 0x1 */
            ii(0x1018_b534, 2); jmpd(0x1018_b559, 0x23); goto l_0x1018_b559; /* jmp 0x1018b559 */
        l_0x1018_b536:
            ii(0x1018_b536, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1018_b538, 3); cmp(eax, memd_a32[ds, edx + 0x8]);      /* cmp eax, [edx+0x8] */
            ii(0x1018_b53b, 2); if(jzd(0x1018_b4fd, -0x40)) goto l_0x1018_b4fd; /* jz 0x1018b4fd */
            ii(0x1018_b53d, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1018_b53f, 3); lea(ebp, esi + 0x1);                    /* lea ebp, [esi+0x1] */
            ii(0x1018_b542, 1); dec(eax);                               /* dec eax */
            ii(0x1018_b543, 3); mov(memd_a32[ds, edx + 0x4], ebp);      /* mov [edx+0x4], ebp */
            ii(0x1018_b546, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1018_b548, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1018_b54a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_b54f, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1018_b551, 2); if(jzd(0x1018_b557, 0x4)) goto l_0x1018_b557; /* jz 0x1018b557 */
            ii(0x1018_b553, 4); or(memb_a32[ds, edx + 0xc], 0x4);       /* or byte [edx+0xc], 0x4 */
        l_0x1018_b557:
            ii(0x1018_b557, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
        l_0x1018_b559:
            ii(0x1018_b559, 2); mov(memb_a32[ds, eax], bl);             /* mov [eax], bl */
            ii(0x1018_b55b, 4); and(memb_a32[ds, edx + 0xc], -0x11 /* 0xef */); /* and byte [edx+0xc], 0xef */
            ii(0x1018_b55f, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
        l_0x1018_b565:
            ii(0x1018_b565, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_b567, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_b568, 1); popd(esi);                              /* pop esi */
            ii(0x1018_b569, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_b56a, 1); retd(); return;                         /* ret */
        }
    }
}